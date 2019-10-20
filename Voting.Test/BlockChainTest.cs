using System;
using System.Collections.Generic;
using System.Linq;
using Votin.Model.Entities;
using Voting.Infrastructure;
using Voting.Service.Services.BlockChainServices;
using Voting.Service.Services.BlockServices;
using Xunit;

namespace Voting.Test
{
    public class BlockChainTest
    {
        private readonly BlockService _blockService = new BlockService();
        private BlockChainService _blockChainService;
        private BlockChainService _blockChainService2;

        [Fact]
        public void BlockChain_Init_Genesis()
        {
            _blockChainService = new BlockChainService(_blockService);

            //var lastBlock = BlockChain.Chain.Last();
            //var genesis = _blockService.GenesisBlock();

            //Assert.Same(genesis, lastBlock);
        }

        [Fact]
        public void BlockChain_Add_AddedShouldBeLast()
        {
        //    var block = _blockChainService.AddBlock("New Block");

        //    var lastBlock = BlockService _blockService.Chain.Last();

        //    Assert.Equal(block, lastBlock);
        }

        [Fact]
        public void BlockChain_IsValid_ValidChain()
        {
            //_blockChainService2 = new BlockChainService(_blockService);

            //Assert.True(_blockChainService.IsValidChain(_blockChainService2.Chain));
        }

        [Fact]
        public void BlockChain_IsValid_InvalidGenesis()
        {
            //_blockChainService2.Chain.First().Data = "bad invalid";

            //Assert.False(_blockChainService.IsValidChain(_blockChainService2.Chain));
        }

        [Fact]
        public void BlockChain_IsValid_InvalidPreviousHash()
        {
            //_blockChainService2.AddBlock("Foo");
            //_blockChainService2.AddBlock("Bar");
            //_blockChainService2.Chain[2].PreviousHash[0] = 1;

            //Assert.False(_blockChainService.IsValidChain(_blockChainService2.Chain));
        }

        [Fact]
        public void BlockChain_IsValid_InvalidHash()
        {
            //_blockChainService2.AddBlock("Foo");
            //_blockChainService2.AddBlock("Bar");
            //_blockChainService2.Chain[2].Hash[0] = 1;

            //Assert.False(_blockChainService.IsValidChain(_blockChainService2.Chain));
        }

        [Fact]
        public void BlockChain_ReplaceChain_ValidChain()
        {

        }

        [Fact]
        public void BlockChain_ReplaceChain_InvalidChainLength()
        {

        }

        [Fact]
        public void BlockChain_ReplaceChain_InvalidChain()
        {

        }
    }
}