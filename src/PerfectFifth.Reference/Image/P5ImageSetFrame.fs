module P5Reference.Image.P5ImageSetFrame

open P5.Core
open P5.Image
open P5.Math
open P5.Events
open P5.Environment

let preload p5 =
    loadImage p5 "assets/arnott-wallace-eye-loop-forever.gif"

let setup _ = id

let draw p5 (gif: P5Image) =
    gif.pause ()
    image p5 gif 0 0
    let maxFrame = gif.numFrames () - 1
    // Set the current frame that is mapped to be relative to mouse position
    let frameNumber = mapBounded p5 (mouseY p5) 0 (height p5) 0 maxFrame |> floor |> int
    gif.setFrame frameNumber

let run node =
    simulateWithPreload node preload setup noUpdate draw
