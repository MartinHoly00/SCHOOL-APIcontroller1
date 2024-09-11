namespace APIcontroller.Controllers
{
    public interface IValueService
    {
        public int Value
        {
            get;
        }

        public void SetValue(int value);
    }
}
