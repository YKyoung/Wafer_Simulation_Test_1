﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WaferLlineLib;

namespace WaferLineCommLib
{
    public class ControlServer
    {
        public event AddLineEventHandler AddedLine;
        public event AddWaferEventHandler AddedWafer;
        public event AddPREventHandler AddedPR;
        public event SetSpeedEventHandler SettedSpeed;
        public event SetDropEventHandler SettedDrop;
        public event EndPREventHandler EndedPR;
        public event EndCoatingEvntHandler EndedCoating;
        string ip;
        int port;
        public ControlServer(string ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }

        delegate void StartDele();
        public void AsyncStart()
        {
            StartDele dele = Start;
            dele.BeginInvoke(null, null);
        }
        public void Start()
        {
            //소켓 생성
            Socket sock = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            //소켓을 네트워크 인터페이스와 결합
            IPAddress addr = IPAddress.Parse(ip);
            IPEndPoint ep = new IPEndPoint(addr, port);
            sock.Bind(ep);
            //백로그 큐 크기 설정
            sock.Listen(5);
            //클라이언트 연결 요청 대기 및 수락 loop
            while (true)
            {
                Socket dosock = sock.Accept();
                DoIt(dosock);
            }
        }

        private void DoIt(Socket dosock)
        {
            byte[] packet = new byte[128];
            dosock.Receive(packet);
            MemoryStream ms = new MemoryStream(packet);
            BinaryReader br = new BinaryReader(ms);
            MsgType msgtype = (MsgType)br.ReadInt32();
            switch (msgtype)
            {
                case MsgType.MSG_FC_ADDLN:AddLineProc(br); break;
                case MsgType.MSG_FC_ADDWF:AddedWaferProc(br); break;
                case MsgType.MSG_FC_ADDRR:AddPrProc(br); break;
                case MsgType.MSG_FC_SETSP:SetSpeedProc(br); break;
                case MsgType.MSG_FC_SETDR:SetDropProc(br); break;
                case MsgType.MSG_FC_ENDPR:EndPrProc(br); break;
                case MsgType.MSG_FC_ENDCO:EndCoatingProc(br); break;
            }
            br.Close();
            ms.Close();
            dosock.Close();              
        }

        private void EndCoatingProc(BinaryReader br)
        {
            int no = br.ReadInt32();
            int bwcnt = br.ReadInt32();
            int awcnt = br.ReadInt32();

            if (EndedCoating != null)
            {
                EndedCoating(this, new EndCoatingEventArgs(no, bwcnt, awcnt));
            }
        }

        private void EndPrProc(BinaryReader br)
        {
            int no = br.ReadInt32();
           
            if (EndedPR != null)
            {
                EndedPR(this, new EndPREventArgs(no));
            }
        }

        private void SetSpeedProc(BinaryReader br)
        {
            int no = br.ReadInt32();
            int speed = br.ReadInt32();
           
            if (SettedSpeed != null)
            {
                SettedSpeed(this, new SetSpeedEventArgs(no, speed));
            }
        }

        private void SetDropProc(BinaryReader br)
        {
            int no = br.ReadInt32();
            int drop = br.ReadInt32();

            if (SettedDrop != null)
            {
                SettedDrop(this, new SetDropEventArgs(no, drop));
            }
        }

        private void AddPrProc(BinaryReader br)
        {
            int no = br.ReadInt32();
            int pcnt = br.ReadInt32();

            if (AddedPR != null)
            {
                AddedPR(this, new AddPREventArgs(no, pcnt));
            }
        }

        private void AddedWaferProc(BinaryReader br)
        {
            int no = br.ReadInt32();
            int bwcnt = br.ReadInt32();
            if (AddedWafer != null)
            {
                AddedWafer(this, new AddWaferEventArgs(no, bwcnt));
            }
        }

        private void AddLineProc(BinaryReader br)
        {
            int no = br.ReadInt32();
            if (AddedLine != null)
            {
                AddedLine(this, new AddLineEventArgs(no));
            }
        }
    }
}
