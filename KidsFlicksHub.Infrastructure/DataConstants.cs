namespace KidsFlicksHub.Infrastructure
{
	public class DataConstants
	{
		//Table Movie
		public const int MovieTitleMaxLength = 50;
		public const int MovieTitleMinLength = 3;

		public const string ReleaseDateTime = "yyyy";
		public const int DurationMaxLength = 180;
		public const int DurationMinLength = 40;

		public const int MovieDescriptionMaxLength = 1000;
		public const int MovieDescriptionMinLength = 50;

		//Table Actor
		public const int ActorFullNameMaxLength = 50;
		public const int ActorFullNameMinLength = 10;

		public const int ActorBiographyMaxLength = 2000;
		public const int ActorBiographyMinLength = 20;

		//Table Director
		public const int DirectorFullNameMaxLength = 50;
		public const int DirectorFullNameMinLength = 10;

		public const int DirectorBiographyMaxLength = 2000;
		public const int DirectorBiographyMinLength = 20;

		//Table User
		public const int UserNameMaxLength = 50;

		public const int UserNameMinLength = 15;

		public const int UserPasswordMaxLength = 15;
		public const int UserPasswordMinLength = 8;

		//Tabel Review

		public const int ReviewCommentMaxLength = 2000;

		//Table Category
		public const int CategoryNameMaxLength = 15;
		
	}
}
