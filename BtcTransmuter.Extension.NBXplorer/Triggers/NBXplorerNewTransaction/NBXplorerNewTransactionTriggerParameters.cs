using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NBXplorer.Models;

namespace BtcTransmuter.Extension.NBXplorer.Triggers.NBXplorerNewTransaction
{
    public class NBXplorerNewTransactionTriggerParameters
    {
        [Required]
        public string CryptoCode { get; set; }
        public string Address { get; set; }
        public string DerivationStrategy { get; set; }
        public int ConfirmationsRequired { get; set; } = 0;
        public List<TransactionResult> Transactions { get; set; }
    }
}