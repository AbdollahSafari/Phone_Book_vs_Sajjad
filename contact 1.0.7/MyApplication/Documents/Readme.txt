********************
*** Solution (1) ***
********************

[[Application]]

	[Models]

		DatabaseContext.cs

		User.cs

********************
*** Solution (2) ***
********************

[[Application]]

[[Models]]

	DatabaseContext.cs

	User.cs

********************
*** Solution (3) ***
********************

[[Application]]

[[Models]]

	User.cs

[[Data]]

	DatabaseContext.cs

********************
*** Solution (4) ***
********************

[[Application]]

[[Domain]]

	User.cs

[[Persistence]]

	DatabaseContext.cs

********************
*** ذهن استقرایی ***
********************

1)

	[[Domain]]

		public class Person : SeedWork.Entity
		{
		}
	
2)

	[[Persistence]]

		DatabaseContext.cs

				public Microsoft.EntityFrameworkCore.DbSet<Domain.Person> People { get; set; }

3)

	[[Persistence]]

		[Configurations]

			PersonConfiguration.cs


***********************
*** خطاها در سی‌شارپ ***
***********************

1. Syntax Error (Compile Error)
2. Logic Error
3. Runtime Error

	3.1. Using if
	3.2. که یا شرطی نمی‌توانیم بنویسیم و یا صرف نمی‌کند

		3.2.1 Error Handling!!!

			...
			...
			...
			try
			{
				...
				...
				...
			}
			catch(System.Exeption ex)
			{
				...
				...
				...
			}
			...
			...
			...

			...
			...
			...
			try
			{
				...
				...
				...
			}
			catch(System.Exeption ex)
			{
				...
				...
				...
			}
			finally
			{
				...
				...
				...
			}
			...
			...
			...
