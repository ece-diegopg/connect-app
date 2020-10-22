namespace connect_back.Domain.Services.Communication
{
    public abstract class BaseResponse<T>
    {
        //los miembros del mensaje(generico)
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public T Entity { get; private set; }

        protected BaseResponse(T dto)//constructor si la operacion fue exitosa
        {
            Success = true;
            Message = string.Empty;
            Entity = dto;
        }

        protected BaseResponse(string message)//constructor si ocurrio un error
        {
            Success = false;
            Message = message;
            Entity = default;
        }
    }
}