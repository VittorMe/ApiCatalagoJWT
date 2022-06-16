using ApiCatalago.Models;

namespace ApiCatalago.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer, string audience, UserModel user);
    }
}
