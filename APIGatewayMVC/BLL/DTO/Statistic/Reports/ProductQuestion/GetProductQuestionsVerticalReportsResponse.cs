﻿using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.ProductQuestion
{
    public class GetProductQuestionsVerticalReportsResponse
    {
        public IEnumerable<ProductQuestionVerticalDTO> Data { get; set; }
        public IEnumerable<Questions> Questions { get; set; }
    }
}
    