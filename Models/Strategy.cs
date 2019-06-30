using System;

namespace BlackjackStrategy.Models
{
    // encapsulates one complete strategy to play Blackjack
    class Strategy : StrategyBase
    {
        private Randomizer randomizer = new Randomizer();

        public Strategy Clone()
        {
            var result = new Strategy();
            result.DeepCopy(this);

            return result;
        }

        HandCodedStrategy strats = new HandCodedStrategy();

        public void Randomize()
        {
            /*
            for (int k = 5; k <= Card.HighestRankIndex; k++)
            {
                SetActionForHardHand(k, 12, ActionToTake.Hit);
                SetActionForHardHand(k, 13, ActionToTake.Hit);
                SetActionForHardHand(k, 14, ActionToTake.Hit);
                SetActionForHardHand(k, 15, ActionToTake.Hit);
                SetActionForHardHand(k, 16, ActionToTake.Hit);

            }

            for (int k = 0; k <= 1 ; k++)
            {
                SetActionForHardHand(k, 12, ActionToTake.Hit);
                

            }

            for (int k = 5; k <= Card.HighestRankIndex; k++)
            {
                SetActionForHardHand(k, 12, ActionToTake.Hit);

            }


            for (int k = 0; k <= Card.HighestRankIndex; k++)
            {
                SetActionForHardHand(k, 11, ActionToTake.Double);
                SetActionForHardHand(k, 8, ActionToTake.Hit);
                SetActionForHardHand(k, 7, ActionToTake.Hit);
                SetActionForHardHand(k, 6, ActionToTake.Hit);
                SetActionForHardHand(k, 5, ActionToTake.Hit);

            }
            SetActionForHardHand(Card.HighestRankIndex, 11, ActionToTake.Hit);
            SetActionForHardHand(3, 5, ActionToTake.Stand);

            for (int k = 0; k <= Card.HighestRankIndex-2; k++)
            {
                SetActionForHardHand(k, 10, ActionToTake.Double);

            }
            

            SetActionForHardHand(Card.HighestRankIndex - 1, 10, ActionToTake.Hit);
            SetActionForHardHand(Card.HighestRankIndex, 10, ActionToTake.Hit);
            SetActionForHardHand(Card.HighestRankIndex - 2, 10, ActionToTake.Hit);

            SetActionForHardHand(0, 9, ActionToTake.Double);

            for (int k = 1; k <= 4; k++)
            {
                SetActionForHardHand(k, 9, ActionToTake.Double);

            }

            for (int k = 5; k <= Card.HighestRankIndex; k++)
            {
                SetActionForHardHand(k, 9, ActionToTake.Hit);

            }

            

            SetActionForSoftHand(4, 8, ActionToTake.Double);

            for (int k = 0; k <= 4; k++)
            {
                SetActionForSoftHand(k, 7, ActionToTake.Double);

            }

            for (int k = 7; k <= 9; k++)
            {
                SetActionForSoftHand(k, 7, ActionToTake.Hit);

            }

            SetActionForSoftHand(0, 6, ActionToTake.Hit);

            for (int k = 1; k <= 4; k++)
            {
                SetActionForSoftHand(k, 6, ActionToTake.Double);

            }

            for (int k = 5; k <= 9; k++)
            {
                SetActionForSoftHand(k, 6, ActionToTake.Hit);

            }



            for (int k = 0; k <= 2; k++)
            {
                SetActionForSoftHand(k, 5, ActionToTake.Hit);
                SetActionForSoftHand(k, 4, ActionToTake.Hit);

            }


            for (int k = 2; k <= 4; k++)
            {
                SetActionForSoftHand(k, 5, ActionToTake.Double);
                SetActionForSoftHand(k, 4, ActionToTake.Double);

            }

            for (int k = 5; k <= 9; k++)
            {
                SetActionForSoftHand(k, 5, ActionToTake.Hit);
                SetActionForSoftHand(k, 4, ActionToTake.Hit);

            }





            for (int k = 0; k <= 3; k++)
            {
                SetActionForSoftHand(k, 2, ActionToTake.Hit);
                SetActionForSoftHand(k, 3, ActionToTake.Hit);

            }


            for (int k = 3; k <= 4; k++)
            {
                SetActionForSoftHand(k, 2, ActionToTake.Double);
                SetActionForSoftHand(k, 3, ActionToTake.Double);

            }

            for (int k = 5; k <= 9; k++)
            {
                SetActionForSoftHand(k, 2, ActionToTake.Hit);
                SetActionForSoftHand(k, 3, ActionToTake.Hit);

            }



            SetActionForSoftHand(1, 4, ActionToTake.Double);
            SetActionForSoftHand(2, 4, ActionToTake.Hit);
            SetActionForSoftHand(4, 8, ActionToTake.Stand);





            for (int upcardRank = 0; upcardRank <= Card.HighestRankIndex; upcardRank++)
            {

                for (int pairRank = 0; pairRank <= Card.HighestRankIndex; pairRank++)
                    SetActionForPair(upcardRank, pairRank, ActionToTake.Split);

            }

            for (int k = 0; k <= Card.HighestRankIndex; k++) SetActionForPair(k, 8, ActionToTake.Stand);


            SetActionForPair(5, 7, ActionToTake.Stand);
            SetActionForPair(8, 7, ActionToTake.Stand);
            SetActionForPair(9, 7, ActionToTake.Stand);



            SetActionForPair(6, 5, ActionToTake.Hit);
            SetActionForPair(7, 5, ActionToTake.Hit);
            SetActionForPair(8, 5, ActionToTake.Hit);
            SetActionForPair(9, 5, ActionToTake.Hit);



            SetActionForPair(5, 4, ActionToTake.Hit);
            SetActionForPair(6, 4, ActionToTake.Hit);
            SetActionForPair(7, 4, ActionToTake.Hit);
            SetActionForPair(8, 4, ActionToTake.Hit);
            SetActionForPair(9, 4, ActionToTake.Hit);

            for (int k = 0; k < Card.HighestRankIndex-1; k++) SetActionForPair(k, 3, ActionToTake.Double);

            SetActionForPair(Card.HighestRankIndex-1, 3, ActionToTake.Hit);
            SetActionForPair(Card.HighestRankIndex, 3, ActionToTake.Hit);

            for (int k = 0; k <= Card.HighestRankIndex ; k++) SetActionForPair(k, 2, ActionToTake.Hit);

            SetActionForPair(3, 2, ActionToTake.Split);
            SetActionForPair(4, 2, ActionToTake.Split);



            SetActionForPair(6, 1, ActionToTake.Hit);
            SetActionForPair(7, 1, ActionToTake.Hit);
            SetActionForPair(8, 1, ActionToTake.Hit);
            SetActionForPair(9, 1, ActionToTake.Hit);


            
            SetActionForPair(6, 0, ActionToTake.Hit);
            SetActionForPair(7, 0, ActionToTake.Hit);
            SetActionForPair(8, 0, ActionToTake.Hit);
            SetActionForPair(9, 0, ActionToTake.Hit);




            SetActionForPair(7, 9, ActionToTake.Hit);
            SetActionForPair(8, 9, ActionToTake.Hit);

           
            SetActionForPair(0, 7, ActionToTake.Stand);
            SetActionForPair(1, 7, ActionToTake.Stand);
            SetActionForPair(2, 7, ActionToTake.Stand);
            SetActionForPair(5, 7, ActionToTake.Stand);
            SetActionForPair(8, 7, ActionToTake.Stand);
            SetActionForPair(9, 7, ActionToTake.Stand);

            SetActionForPair(7, 6, ActionToTake.Hit);

            SetActionForPair(2, 5, ActionToTake.Stand);
            SetActionForPair(6, 5, ActionToTake.Split);

            SetActionForPair(0, 4, ActionToTake.Stand);
            SetActionForPair(1, 4, ActionToTake.Hit);
            SetActionForPair(2, 4, ActionToTake.Stand);

            SetActionForPair(5, 3, ActionToTake.Hit);
            SetActionForPair(7, 3, ActionToTake.Hit);
            SetActionForPair(8, 3, ActionToTake.Hit);
            SetActionForPair(9, 3, ActionToTake.Double);

            SetActionForPair(0, 2, ActionToTake.Split);
            SetActionForPair(1, 2, ActionToTake.Hit);
            SetActionForPair(2, 2, ActionToTake.Split);
            SetActionForPair(3, 2, ActionToTake.Split);
            SetActionForPair(4, 2, ActionToTake.Hit);
          

            SetActionForPair(0, 1, ActionToTake.Hit);
            SetActionForPair(1, 1, ActionToTake.Hit);
            SetActionForPair(6, 1, ActionToTake.Split);
            SetActionForPair(9, 1, ActionToTake.Stand);

            SetActionForPair(1, 0, ActionToTake.Hit);
            */
            
                        for (int upcardRank = 0; upcardRank <= Card.HighestRankIndex; upcardRank++)
                        {





                            // randomize pairs
                            for (int pairRank = 0; pairRank <= Card.HighestRankIndex; pairRank++)
                                 SetActionForPair(upcardRank, pairRank, GetRandomAction(true));

                                //SetActionForPair(upcardRank, pairRank, ActionToTake.Hit);

                            // and soft hands
                            for (int softRemainder = 2; softRemainder <= HighestSoftHandRemainder; softRemainder++)
                                 SetActionForSoftHand(upcardRank, softRemainder, GetRandomAction(false));
                               // SetActionForSoftHand(upcardRank, softRemainder, ActionToTake.Hit);

                            // and hard hands
                            for (int hardValue = 5; hardValue <= HighestHardHandValue; hardValue++)
                                 SetActionForHardHand(upcardRank, hardValue, GetRandomAction(false));
                               // SetActionForHardHand(upcardRank, hardValue, ActionToTake.Hit);
                        } 
        }

        public void Mutate(double impact)
        {
            // impact is the % of cells that should be mutated

            // randomly set cells in each of the arrays
            int NumPairMutations = (int) (100F * impact);     // 10 possible holdings x 10 upcards
            int NumSoftMutations = (int) (80F * impact);     // 8 possible holdings
            int NumHardMutations = (int) (160F * impact);     // 16 possible holdings

            // pairs
            for (int i = 0; i < NumPairMutations; i++)
            {
                var upcardRank = GetRandomRankIndex();
                var randomPairRank = GetRandomRankIndex();
                SetActionForPair(upcardRank, randomPairRank, GetRandomAction(true));
            }

            // soft hands
            for (int i = 0; i < NumSoftMutations; i++)
            {
                var upcardRank = GetRandomRankIndex();
                var randomRemainder = randomizer.IntBetween(LowestSoftHandRemainder, HighestSoftHandRemainder);
                SetActionForSoftHand(upcardRank, randomRemainder, GetRandomAction(false));
            }

            // hard hands
            for (int i = 0; i < NumHardMutations; i++)
            {
                var upcardRank = GetRandomRankIndex();
                var hardTotal = randomizer.IntBetween(LowestHardHandValue, HighestHardHandValue);
                SetActionForHardHand(upcardRank, hardTotal, GetRandomAction(false));
            }
        }

        private int GetRandomRankIndex()
        {
            return randomizer.IntLessThan(Card.HighestRankIndex);
        }

        private ActionToTake GetRandomAction(bool includeSplit)
        {
            return includeSplit ? 
                (ActionToTake)randomizer.IntLessThan(NumActionsWithSplit) :
                (ActionToTake)randomizer.IntLessThan(NumActionsNoSplit);
        }

        public void CrossOverWith(Strategy otherParent, Strategy child)
        {
            // here we create one child, with genetic information from each parent 
            // in proportion to their relative fitness scores
            float myScore = this.Fitness;
            float theirScore = otherParent.Fitness;
            float percentageChanceOfMine = 0;

            // it depends on whether the numbers are positive or negative
            if (myScore >= 0 && theirScore >= 0)
            {
                float totalScore = (myScore + theirScore);
                // safety check (avoiding / 0)
                if (totalScore < 0.001) totalScore = 1;
                percentageChanceOfMine = (myScore / totalScore);
            }
            else if (myScore >= 0 && theirScore < 0)
            {
                // hard to compare a positive and a negative, so let's tip the hat to Mr. Pareto
                percentageChanceOfMine = 0.8F;
            }
            else if (myScore < 0 && theirScore >= 0)
            {
                // hard to compare a positive and a negative, so let's tip the hat to Mr. Pareto
                percentageChanceOfMine = 0.2F;
            }
            else
            {
                // both negative, so use abs value and 1-(x)
                myScore = Math.Abs(myScore);
                theirScore = Math.Abs(theirScore);
                percentageChanceOfMine = 1 - (myScore / (myScore + theirScore));
            }

            for (int upcardRank = 0; upcardRank <= Card.HighestRankIndex; upcardRank++)
            {
                // populate the pairs
                for (int pairRank = 0; pairRank <= Card.HighestRankIndex; pairRank++)
                {
                    bool useMyAction = randomizer.GetFloatFromZeroToOne() < percentageChanceOfMine;
                    child.SetActionForPair(upcardRank, pairRank, 
                        useMyAction ?
                            this.GetActionForPair(upcardRank, pairRank) :
                            otherParent.GetActionForPair(upcardRank, pairRank));
                }

                // populate the soft hands
                for (int softRemainder = LowestSoftHandRemainder; softRemainder <= HighestSoftHandRemainder; softRemainder++)
                {
                    bool useMyAction = randomizer.GetFloatFromZeroToOne() < percentageChanceOfMine;
                    child.SetActionForSoftHand(upcardRank, softRemainder, 
                        useMyAction ?
                        this.GetActionForSoftHand(upcardRank, softRemainder) :
                        otherParent.GetActionForSoftHand(upcardRank, softRemainder));
                }

                // populate the hard hands
                for (int hardValue = LowestHardHandValue; hardValue <= HighestHardHandValue; hardValue++)
                {
                    bool useMyAction = randomizer.GetFloatFromZeroToOne() < percentageChanceOfMine;
                    child.SetActionForHardHand(upcardRank, hardValue, 
                        useMyAction ?
                        this.GetActionForHardHand(upcardRank, hardValue) :
                        otherParent.GetActionForHardHand(upcardRank, hardValue));
                }
            }
        }
    }
}