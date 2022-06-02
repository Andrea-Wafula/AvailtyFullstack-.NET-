using System;

namespace LISPChekcerClassLibrary
{
    public interface IWord
    {
        string Input { get; set; }
    }

    public class Word : IWord
    {
        #region Fields
        string _input;        
        #endregion

        #region Properties
        public string Input { get; set; }

        #endregion

        #region Constructors
        #endregion

        #region Methods

        public bool Checker(string Input)
        {
            if (true)
            {

            }

            return true;
        }

        #endregion



    }
}
