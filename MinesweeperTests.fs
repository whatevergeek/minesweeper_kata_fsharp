module MinesweeperTests

open Xunit

open Minesweeper

[<Fact>]
let ``Test that 1 + 2 is 3`` () =
    let expected = 3
    let actual = Add(1, 2)
    Assert.Equal(expected, actual)
