namespace InglemoorCodingComputing.Models;

public record AppUser
{
    public Guid Id { get; init; }

    public int StudentNumber { get; init; }

    public string FirstName { get; init; } = string.Empty;

    public string LastName { get; init; } = string.Empty;

    public int GraduationYear { get; init; }

    public DateTime CreatedDate { get; init; }

    public DateTime? DeletedDate { get; init; }

    public static int AcademicYear => ToAcademicYear(DateTime.UtcNow);

    public static int ToAcademicYear(DateTime dt) =>
        new DateTime(dt.Year, 8, 1) > dt
        ? dt.Year
        : dt.Year + 1;

    public static int CalenderYear(int academicYear, int month, int day) =>
        new DateTime(DateTime.UtcNow.Year, 8, 1) > new DateTime(DateTime.UtcNow.Year, month, day)
        ? academicYear
        : academicYear - 1;

    public static int GradeLevelToGraduationYear(int grade) =>
        12 - grade + AcademicYear;
}