module P5Reference.Math.Radians

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let deg = 45.0
    let rad = radians p5 deg
    // Prints: 45 degrees is 0.7853981633974483 radians
    print p5 (sprintf "%.0f degrees is %f radians" deg rad)

let run node = display node draw
