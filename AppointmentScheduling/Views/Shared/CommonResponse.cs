namespace AppointmentScheduling.Views.Shared
{
    public class CommonResponse<T>
    {
        public int status { get; set; }

        public string message { get; set; }

        public T datenum { get; set; }
    }
}
