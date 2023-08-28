using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user), Messages.ClaimsListed);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<User> GetByMail(string email)
        {
            User? user = _userDal.Get(u => u.Email == email);
            if (user == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }
    }
}
