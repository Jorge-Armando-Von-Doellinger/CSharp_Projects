namespace API.Models.Response
{
    public class Response<T>
    {
        public Response()
        {
            ResponseStatus = 200;
        }

        public string Message { get; set; }
        public int ResponseStatus { get; set; }
        public T? Data { get; set; }
    }
}
