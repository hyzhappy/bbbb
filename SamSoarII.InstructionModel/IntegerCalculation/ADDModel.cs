﻿using SamSoarII.ValueModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamSoarII.InstructionModel
{
    public class ADDModel : BaseModel
    {
        public WordValue InputValue1 { get; set; }
        public WordValue InputValue2 { get; set; }
        public WordValue OutputValue { get; set; }
        public ADDModel()
        {
            InputValue1 = WordValue.Null;
            InputValue2 = WordValue.Null;
            OutputValue = WordValue.Null;
        }

        public ADDModel(WordValue inputValue1, WordValue inputValue2, WordValue outputValue)
        {
            InputValue1 = inputValue1;
            InputValue2 = inputValue2;
            OutputValue = outputValue;
        }

        public override string GenerateCode()
        {
            throw new NotImplementedException();
        }
    }
}
