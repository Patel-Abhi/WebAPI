using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.DomainModel
{
   public class UserAddress
    {
       public int UserId { get; set; }
       public string DeliveryAddress { get; set; }
       public Boolean IsDefaultAddress { get; set; }
       public AddressType AddressType { get; set; }
    }
    public enum AddressType
    {
        OfficeAddress=0,
        HomeAddress=1
    }
}
