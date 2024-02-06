using MernisServiceReference;
using WorkAround.Bussines.Abstract;
using WorkAround.Entities.Concrete;
namespace WorkAround.Bussines.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoap client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
            new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
    }
}
