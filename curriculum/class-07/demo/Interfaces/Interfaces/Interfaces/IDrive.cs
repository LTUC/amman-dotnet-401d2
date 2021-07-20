using System;
namespace Interfaces.Interfaces
{
  public interface IDrive
  {
    /// <summary>
    /// The state that the drivers license was issued
    /// </summary>
    string StateLicense { get; set; }

    /// <summary>
    /// Adjust the settings of the vehichle. 
    /// </summary>
    /// <returns>all of the settings adjusted</returns>
    string AdjustSettings();
  }
}
