﻿using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.ProductQuestion
{
    public class GetProductQuestionsHorizontalReportsResponse
    {
        public IEnumerable<ProductQuestionHorizontalDTO> Data { get; set; }
        public IEnumerable<Questions> Questions { get; set; }
    }
}
