using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DlrModel.Model;
namespace DzoAuthService
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        Token Authenticate(string login, string password);

        [OperationContract]
        List<ActBase> GetActs(Token token, int count, int offset);

        [OperationContract]
        List<ActCommon> GetActsCommon(Token token, int count, int offset);

        [OperationContract]
        List<ActIndividual> GetActsIndividual(Token token, int count, int offset);

        [OperationContract]
        List<ActInpectationFl> GetActsInpectationFl(Token token, int count, int offset);

        [OperationContract]
        List<ActInspectationUlIp> GetActsInspectationUlIp(Token token, int count, int offset);

        [OperationContract]
        List<ActInspection> GetActInspection(Token token, int count, int offset);

        [OperationContract]
        List<AgreementStatement> GetAgreementStatements(Token token, int count, int offset);

        [OperationContract]
        List<AreaMeasurement> GetAreaMeasurements(Token token, int count, int offset);

        [OperationContract]
        List<CheckingJournal> GetCheckingJournals(Token token, int count, int offset);

        [OperationContract]
        List<CitizensCheckPlan> GetCitizensCheckPlans(Token token, int count, int offset);

        [OperationContract]
        List<OrderInspectionUlIp> GetOrdersInspectionUlIp(Token token, int count, int offset);

        [OperationContract]
        List<PhotoTable> GetPhotoTables(Token token, int count, int offset);

        [OperationContract]
        List<Protocol> GetProtocols(Token token, int count, int offset);

        [OperationContract]
        List<Regulation> GetRegulations(Token token, int count, int offset);

        [OperationContract]
        List<Photo> GetPhotoTablePhotos(Token token, PhotoTable photoTable);

        [OperationContract]
        bool UpdateAct(ActBase act, Token token);

        [OperationContract]
        bool DeleteActById(int id, Token token);

        [OperationContract]
        bool DeleteAct(ActBase act, Token token);

        [OperationContract]
        bool AddAct(ActBase act, Token token);
    }
}
