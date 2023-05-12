using Microsoft.AspNetCore.Identity;

namespace PresentationLayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{

		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = $"Parola en az {length} karakterden oluşmalıdır."
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = $"Parola en az 1 büyük harften oluşmalıdır."
			};
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = $"Parola en az 1 küçük harften oluşmalıdır."
			};
		}

		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = $"Parola en az 1 rakamdan oluşmalıdır."
			};
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = $"Parola en az 1 sembolden oluşmalıdır."
			};
		}

	}
}
