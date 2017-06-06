using DiscountCrazyAdmin.Data;
using DiscountCrazyAdmin.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountCrazyAdmin.Services
{
    public interface IDiscountService
    {
        Code GetCodeById(int id);
        CodeUsedHistory GetCodeUsedHistoryById(int id);
        DiscountType GetDiscountTypeById(int id);
        PromotionCode GetPromotionCodeById(int id);
    }

    public class DiscountService : IDiscountService
    {
        private readonly ICodeRepository _codeRepository;
        private readonly ICodeUsedHistoryRepository _codeUsedRepository;
        private readonly IDiscountTypesRepository _discountTypeRepository;
        private readonly IPromotionCodeRepository _promoRepository;

        public DiscountService(ICodeRepository codeRepository, ICodeUsedHistoryRepository codeUsedRepository, 
            IDiscountTypesRepository discountTypeRepository, IPromotionCodeRepository promoteRepository)
        {
            _codeRepository = codeRepository;
            _codeUsedRepository = codeUsedRepository;
            _discountTypeRepository = discountTypeRepository;
            _promoRepository = promoteRepository;
        }
        public Code GetCodeById(int id)
        {
            return _codeRepository.GetById(id);
        }

        public CodeUsedHistory GetCodeUsedHistoryById(int id)
        {
            return _codeUsedRepository.GetById(id);
        }

        public DiscountType GetDiscountTypeById(int id)
        {
            return _discountTypeRepository.GetById(id);
        }

        public PromotionCode GetPromotionCodeById(int id)
        {
            return _promo.get(id);
        }
    }
}
