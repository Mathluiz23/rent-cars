namespace RentCars.Types;

// A struct deve conter o campo Name do tipo string
// A struct deve conter o campo Hex do tipo string

public struct Color
{
  public string Name { get; set; }
  public string Hex { get; set; }

  public Color(string name, string hex)
  {
    Name = name;
    Hex = hex;
  }
}
