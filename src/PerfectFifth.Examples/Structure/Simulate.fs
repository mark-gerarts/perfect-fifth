module P5Examples.Structure.Simulate

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Math

// The state can be anything. In this case it is a record,
// but scalars, tuples, classes, etc. work as well.
type State = { x: float; c: Color }

let setup p5 =
    createCanvas p5 100 100

    // Setup must return some initial state.
    { x = 0; c = (Grayscale 0) }

// Update receives the current state and returns the new one.
let update p5 state =
    let newX =
        match state.x + 1.0 with
        | 100.0 -> 0.0
        | x -> x

    // Switch colors every 10 steps.
    let newColor =
        match newX % 10.0 with
        | 0.0 -> RGB(randomBetween p5 0 255, randomBetween p5 0 255, randomBetween p5 0 255)
        | _ -> state.c

    { x = newX; c = newColor }

let draw p5 state =
    background p5 (Grayscale 0)
    fill p5 state.c
    square p5 state.x 50 20

let run node = simulate node setup update draw
