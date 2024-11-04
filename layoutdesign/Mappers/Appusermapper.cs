using layoutdesign.DTo;
using layoutdesign.Models;

namespace layoutdesign.Mappers
{
    public static class Appusermapper
    {
        public static Appuser ToRegistation(this Registerdto registerdto)
        {
            return new Appuser
            {
                FisrtName = registerdto.FisrtName,
                LastName = registerdto.LastName,
                Email = registerdto.Email,
                PhoneNumber = registerdto.PhoneNumber,
                UserName=registerdto.FisrtName.ToLower()  + registerdto.LastName.ToLower(),
                

            };
        }

    }
}
