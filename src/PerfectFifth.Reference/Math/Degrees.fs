module P5Reference.Math.Degrees

open P5.Core
open P5.Environment
open P5.Math

let draw p5 =
    let rad = pi / 4.0
    let deg = degrees p5 rad
    // Prints: 0.7853981633974483 radians is 45 degrees
    print p5 (sprintf "%f radians is %.0f degrees" rad deg)

let run node = display node draw
