using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ActsModel;

namespace DzoAuthService
{
    // PLACSIN
    // проверки требований
    // надежность программногоо обеспечения майерс
    // виды обслуживания, персонал
    // требования к программной документации таблица из 3 граф название очем читатель(кто)
    // технико эконом харки: ориентировачная эконом эфф проги
    // предлагаемая годовая потребность
    // стадии и этапы разработки
    // в плане стопроц события
    // порядок контроля
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        Token Authenticate(string login, string password);

        [OperationContract]
        List<Act> GetActs(Token token, int count, int offset);

        [OperationContract]
        bool DeleteAct(Act act, Token token);

        [OperationContract]
        bool AddAct(Act act, Token token);
    }
}
