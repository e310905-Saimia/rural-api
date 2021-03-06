﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RuralAPI.Models;

namespace RuralAPI.Services
{
    public interface IQuestionChoicesService
    {
        List<QuestionChoice> GetAll();
        QuestionChoice Get(long id);
    }
}
