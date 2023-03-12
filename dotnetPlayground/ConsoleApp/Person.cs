namespace ConsoleApp;

public class Person { }

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder) { }
}
