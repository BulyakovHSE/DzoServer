using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ActsModel;
using ActsModel.Model;

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
        List<ActBase> GetSomeActs(Token token, Func<ActBase, bool> predicate);

        [OperationContract]
        List<ActCommon> GetActsCommon(Token token, Func<ActCommon, bool> predicate);

        [OperationContract]
        List<ActIndividual> GetActsIndividual(Token token, Func<ActIndividual, bool> predicate);
        
        [OperationContract]
        List<ActInpectationFl> GetActsInpectationFl(Token token, Func<ActInpectationFl, bool> predicate);
        
        [OperationContract]
        List<ActInspectationUlIp> GetActsInspectationUlIp(Token token, Func<ActInspectationUlIp, bool> predicate);
        
        [OperationContract]
        List<ActInspection> GetActInspection(Token token, Func<ActInspection, bool> predicate);
        
        [OperationContract]
        List<AgreementStatement> GetAgreementStatements(Token token, Func<AgreementStatement, bool> predicate);
        
        [OperationContract]
        List<AreaMeasurement> GetAreaMeasurements(Token token, Func<AreaMeasurement, bool> predicate);
        
        [OperationContract]
        List<CheckingJournal> GetCheckingJournals(Token token, Func<CheckingJournal, bool> predicate);
        
        [OperationContract]
        List<CitizensCheckPlan> GetCitizensCheckPlans(Token token, Func<CitizensCheckPlan, bool> predicate);
        
        [OperationContract]
        List<OrderInspectionUlIp> GetOrdersInspectionUlIp(Token token, Func<OrderInspectionUlIp, bool> predicate);
        
        [OperationContract]
        List<PhotoTable> GetPhotoTables(Token token, Func<PhotoTable, bool> predicate);
        
        [OperationContract]
        List<Protocol> GetProtocols(Token token, Func<Protocol, bool> predicate);
        
        [OperationContract]
        List<Regulation> GetRegulations(Token token, Func<Regulation, bool> predicate);

        [OperationContract]
        bool DeleteAct(ActBase act, Token token);

        [OperationContract]
        bool AddAct(ActBase act, Token token);
    }
}
