using CoreWCF;

using Lab3Net6.Data.Models;

namespace Lab3Net6.Server.Services;

[ServiceContract]
public interface IUserService
{
	[OperationContract]
	[FaultContract(typeof(string))]
	User? LogIn(string username, string password);

	[OperationContract]
	[FaultContract(typeof(string))]
	User? Register(string username, string password);
}
