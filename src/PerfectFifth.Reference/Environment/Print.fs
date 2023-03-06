module P5Reference.Environment.Print

open P5.Core
open P5.Environment

let draw p5 =
    let x = 10

    print p5 <| sprintf "The value of x is %A" x

let run node = display node draw
