using RecurssionApp;
using System.Collections.Generic;

namespace RecurrsiveTest
{
    public class GraphTreeTest
    {
        [Fact]
        public void TestMaxDepth()
        {
            // Given
            GraphTree tree = new GraphTree(
                new[]
                {
                    new Node("F", "E"),
                    new Node("D", "C" ),
                    new Node ("I", "G"),
                    new Node("E", "C"),
                    new Node("B", "A"),
                    new Node("G", "E"),
                    new Node("A", null),
                    new Node ("C", "A"),
                    new Node ("H", "G")
                });
            
            // When
             var result = tree.MaxDepth();

            // Then
             Assert.Equal(4, result);
        }
    }
}