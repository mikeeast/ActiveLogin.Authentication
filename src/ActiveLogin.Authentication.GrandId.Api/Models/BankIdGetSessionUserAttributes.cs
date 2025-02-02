using System.Runtime.Serialization;

namespace ActiveLogin.Authentication.GrandId.Api.Models;

[DataContract]
public class BankIdGetSessionUserAttributes
{
    public BankIdGetSessionUserAttributes(string signature, string ocspResponse, string givenName, string surname, string name, string personalIdentityNumber, string notBefore, string notAfter, string ipAddress)
    {
        Signature = signature;
        OcspResponse = ocspResponse;
        GivenName = givenName;
        Surname = surname;
        Name = name;
        PersonalIdentityNumber = personalIdentityNumber;
        NotBefore = notBefore;
        NotAfter = notAfter;
        IpAddress = ipAddress;
    }

    [DataMember(Name = "signature")]
    public string Signature { get; private set; }

    [DataMember(Name = "ocspResponse")]
    public string OcspResponse { get; private set; }

    [DataMember(Name = "givenName")]
    public string GivenName { get; private set; }

    [DataMember(Name = "surname")]
    public string Surname { get; private set; }

    [DataMember(Name = "name")]
    public string Name { get; private set; }

    [DataMember(Name = "personalNumber")]
    public string PersonalIdentityNumber { get; private set; }

    [DataMember(Name = "notBefore")]
    public string NotBefore { get; private set; }

    [DataMember(Name = "notAfter")]
    public string NotAfter { get; private set; }

    [DataMember(Name = "ipAddress")]
    public string IpAddress { get; private set; }
}