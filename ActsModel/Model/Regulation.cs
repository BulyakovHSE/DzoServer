using System;
using System.Runtime.Serialization;

namespace ActsModel.Model
{
    /// <summary>
    /// ПРЕДПИСАНИЕ УСТРАНЕНИЯ НАРУШЕНИЯ ЗЕМ ЗАКОНА
    /// </summary>
    [DataContract]
    public class Regulation : ActIndividual
    {
        public Regulation():base(ActType.ПредписаниеУтсрНарушЗемЗакона){}

        /// <summary>
        /// ПРЕДПИСАНИЕ об устранении нарушения земельного законодательства от
        /// "___" ____________ 20___ г.
        /// </summary>
        [DataMember]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Номер предписания
        /// </summary>
        [DataMember]
        public string Num { get; set; }

        /// <summary>
        /// (должность, Ф.И.О. должностного лица, составившего предписание)
        /// </summary>
        [DataMember]
        public string CreatorInfo { get; set; }

        /// <summary>
        /// в  порядке осуществления муниципального земельного контроля провел проверку соблюдения 
        /// земельного законодательства на земельном участке, расположенном по адресу:
        /// </summary>
        [DataMember]
        public string AreaAddress { get; set; }

        /// <summary>
        /// Площадью (без кв.м)
        /// </summary>
        [DataMember]
        public string AreaSquare { get; set; }

        /// <summary>
        /// Земельный участок используется (наименование юридического лица, руководитель, ИНН, юридический адрес, 
        /// банковские реквизиты, телефоны; Ф.И.О. должностного лица или гражданина, ИНН, паспортные данные, адрес места жительства, телефон)
        /// </summary>
        [DataMember]
        public string AreaUserInfo { get; set; }

        /// <summary>
        /// В  результате  проверки  выявлено нарушение земельного законодательства Российской Федерации, выразившееся в:
        /// (описание нарушения)
        /// </summary>
        [DataMember]
        public string ViolationDescription { get; set; }

        /// <summary>
        /// Указанное нарушение допущено: 
        /// наименование юридического лица, должностного лица,индивидуального предпринимателя, физического лица
        /// </summary>
        [DataMember]
        public string ViolationAuthorInfo { get; set; }


        /// <summary>
        /// Я
        /// (должность, Ф.И.О.)
        /// </summary>
        [DataMember]
        public string CreatorInfoFirstName { get; set; }

        /// <summary>
        /// ОБЯЗЫВАЮ:
        /// наименование юридического лица, Ф.И.О. руководителя, должностное лицо, индивидуальный предприниматель, физическое лицо
        /// </summary>
        [DataMember]
        public string ViolationAuthor2 { get; set; }

        /// <summary>
        /// устранить допущенное нарушение до
        /// "___" ____________ 20___ г.
        /// </summary>
        [DataMember]
        public DateTime? CorrectToDate { get; set; }

        /// <summary>
        /// Информацию   об   исполнении   предписания  с  приложением  документов,
        /// подтверждающих устранение  земельного правонарушения, или  ходатайство о
        /// продлении срока исполнения предписания с указанием причин и принятых мер по
        /// устранению   земельного правонарушения, подтвержденных  соответствующими
        /// документами и другими материалами, представлять в 
        /// (наименование органа муниципального земельного контроля)
        /// </summary>
        [DataMember]
        public string MunicipalAuthorityForDocuments { get; set; }

        /// <summary>
        /// по адресу:
        /// </summary>
        [DataMember]
        public string MunicipalAuthorityAddress { get; set; }

        /// <summary>
        /// !!!ПОД ВОПРОСОМ. НЕ ЗНАЮ КАК ВЫГЛЯДИТ ОТМЕТКА!!!
        /// (отметка о вручении предписания)
        /// </summary>
        [DataMember]
        public string PrescriptionDeliveryMark { get; set; }
    }
}
