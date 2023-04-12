module P5Reference.Math.Mag

open P5.Core
open P5.Math
open P5.Environment
open P5.Shape

let draw p5 =
    let x1 = 20
    let x2 = 80
    let y1 = 30
    let y2 = 70

    line p5 0 0 x1 y1
    print p5 (mag p5 x1 y1 |> string) // Prints "36.05551275463989"
    line p5 0 0 x2 y1
    print p5 (mag p5 x2 y1 |> string) // Prints "85.44003745317531"
    line p5 0 0 x1 y2
    print p5 (mag p5 x1 y2 |> string) // Prints "72.80109889280519"
    line p5 0 0 x2 y2
    print p5 (mag p5 x2 y2 |> string) // Prints "106.3014581273465"

let run node = display node draw
