module P5Reference.Math.Random2

open P5.Core
open P5.Math
open P5.Typography

let draw p5 =
    // Get a random element from an array using the random(Array) syntax
    let words = [ "apple"; "bear"; "cat"; "dog" ]
    let word = randomChoice p5 words // select random word
    text p5 word 10 50 // draw the word
    console.log (randomMax p5 3 |> string)

let run node = display node draw
