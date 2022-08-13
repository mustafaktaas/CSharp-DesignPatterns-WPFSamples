using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace WcfService1
{
    // NOT: "IService1" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string name(string name);

    }


    
   
}
