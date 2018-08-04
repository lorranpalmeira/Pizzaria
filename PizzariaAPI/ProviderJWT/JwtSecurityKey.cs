using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace PizzariaAPI.ProviderJWT
{
    public class JwtSecurityKey
    {

        public static SymmetricSecurityKey Create(string secret){

            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secret));
        }
        
    }
}