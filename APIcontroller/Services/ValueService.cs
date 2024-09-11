using APIcontroller.Controllers;
using Microsoft.Net.Http.Headers;

namespace APIcontroller.Services
{
    public class ValueService : IValueService
    {
        //pamatováníí si promenne kdyz pres set nastavime a potom chceme pres get ziskat - jinak si nepamatuje
        public int Value { get; private set; }

        public ValueService()
        {
            Value = Random.Shared.Next(0, 100);
        }
        public void SetValue(int val) {  Value = val; }
    }
}
