
namespace WaferLlineLib
{
    /// <summary>
    /// Wafer 클라스
    /// </summary>
    public class Wafer
    {
        static int last_wn;
        readonly int wn;
        int[] cells = new int[100];
        int now;
        /// <summary>
        /// 기본생성자
        /// </summary>
        public Wafer()
        {
            last_wn++;
            wn = last_wn;
        }
        /// <summary>
        /// 현재 코팅할 셀 번호-가져오기
        /// </summary>
        public int Now
        {
            get
            {
                return now;
            }
        }
        /// <summary>
        /// 코팅할 셀 번호 증가
        /// </summary>
        /// <returns>증가 성공여부</returns>
        public bool Increment()
        {

            if (now < 100)
            {
                now++;
                if (now == 100)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// 코팅 메서드
        /// </summary>
        /// <param name="quality">품질 수준</param>
        public void Coating(int quality)
        {
            if (Now < 100)
            {
                cells[Now] = quality;
            }
        }
        /// <summary>
        /// 특정 셀의 품질 수준 인덱서-거져오기
        /// </summary>
        /// <param name="index"></param>
        /// <returns>특정 셀의 품질</returns>
        public int this[int index]
        {
            get
            {
                if ((index < 0) || (index >= 100))
                {
                    return 0;  // throw를 던질수도 있음.
                }
                return cells[index];
            }
        }
        /// <summary>
        /// 100개의 셀에 대한 평균 품질
        /// </summary>
        public double Quality
        {
            get
            {
                int sum = 0;
                foreach (int elem in cells)
                {
                    sum += elem;
                }
                return sum / 100.0;
            }
        }
        /// <summary>
        /// ToString 메서드 재저의
        /// </summary>
        /// <returns>Wsfer 번호, 평균 품질</returns>
        public override string ToString()
        {
            return string.Format("No:{0}, Quality: {1}", wn, Quality);
        }

    }
}
