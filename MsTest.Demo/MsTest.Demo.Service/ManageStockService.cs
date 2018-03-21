using Mstest.Demo.DAL;
using MsTest.Demo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTest.Demo.Service
{
    public class ManageStockService
    {
        private readonly IGenericRepository<Stock> _dbStock;
        private readonly IGenericRepository<TrandingTransactionHistory> _dbTradeTransaction;
        private readonly IUnitOfWork _unitOfWork;
        private MSDemoDBEntities _dbContext;
        private ILogHandler _log;
        public ManageStockService()
        {
            _dbContext = new MSDemoDBEntities();
            _dbStock = new GenericRepository<Stock>(_dbContext);
            _dbTradeTransaction = new GenericRepository<TrandingTransactionHistory>(_dbContext);
            _unitOfWork = new UnitOfWork(_dbContext);
            _log = new LogHandler();
        }

        public List<Stock> GetAllStocks()
        {
            var list = new List<Stock>();
            try
            {
                list = _dbStock.GetAll().ToList();
            }
            catch(Exception ex)
            {
                _log.LogError(ex.Message);
                throw ex;
            }
            return list;
        }

        public void AddStock(Stock stock)
        {
            try
            {
                _dbStock.Insert(stock);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message);
                throw ex;
            }
        }

        public void AddTransaction(TrandingTransactionHistory tradeTransaction)
        {
            try
            {
                tradeTransaction.StatusType = "Active";
                tradeTransaction.CreateDate = DateTime.Now;
                tradeTransaction.ModifiedDate = DateTime.Now;
                _dbTradeTransaction.Insert(tradeTransaction);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message);
                throw ex;
            }

        }
    }
}
