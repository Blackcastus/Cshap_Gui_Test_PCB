using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Tool_Test_Ontrak_Pannel
{
    public class KalmanFilter
    {
        private double x;  // Ước lượng trạng thái (ví dụ: tần số)
        private double P;  // Sai số ước lượng
        private double Q;  // Phương sai của quá trình (process noise)
        private double R;  // Phương sai của phép đo (measurement noise)

        private readonly int windowSize;
        private readonly Queue<double> samples;

        public KalmanFilter(double initialValue, double initialCovariance, double processVariance, double measurementVariance)
        {
            x = initialValue;
            P = initialCovariance;
            Q = processVariance;
            R = measurementVariance;

            this.windowSize = 1000;
            samples = new Queue<double>(windowSize);
        }

        /// <summary>
        /// Cập nhật bộ lọc Kalman với phép đo mới và trả về giá trị ước lượng đã lọc.
        /// </summary>
        /// <param name="measurement">Giá trị đo được (tần số)</param>
        /// <returns>Giá trị ước lượng đã được lọc</returns>
        public double Update(double measurement)
        {
            // Bước 1: Prediction update
            // Ước lượng không đổi, chỉ cập nhật sai số ước lượng
            P = P + Q;

            // Bước 2: Measurement update
            double K = P / (P + R);      // Hệ số Kalman
            x = x + K * (measurement - x);  // Cập nhật ước lượng với hiệu giữa phép đo và giá trị ước lượng
            P = (1 - K) * P;           // Cập nhật sai số ước lượng

            return x;
        }

        public double Filter(double newSample)
        {
            // Thêm mẫu mới vào queue
            samples.Enqueue(newSample);

            // Nếu số mẫu vượt quá kích thước cửa sổ, loại bỏ mẫu cũ nhất
            if (samples.Count > windowSize)
                samples.Dequeue();

            // Tính trung bình của các mẫu hiện có
            return samples.Average();
        }
    }
}
