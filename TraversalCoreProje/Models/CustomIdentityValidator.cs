using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Şifre minimum {length} karakter olmalıdır."
			};


		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Şifrede en az 1 küçük harf olmalıdır."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code= "PasswordRequiresUpper",
				Description = "Şifrede en az bir büyük harf olmalıdır."
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code= "PasswordRequiresDigit",
				Description = "Şifrede en az bir rakam ( [0-9] arasında ) olmalıdır "
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Şifrede en az bir sembol olmalıdır."
			};
		}
	}
}
