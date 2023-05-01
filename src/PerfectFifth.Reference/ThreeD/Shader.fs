module P5Reference.ThreeD.Shader

open P5.Core
open P5.Color
open P5.Shape
open P5.ThreeD
open P5.Rendering

type State =
    { redGreen: P5Shader
      orangeBlue: P5Shader
      showRedGreen: bool }

let preload p5 =
    let redGreen = loadShader p5 "assets/shader.vert" "assets/shader-gradient.frag"
    let orangeBlue = loadShader p5 "assets/shader.vert" "assets/shader-gradient.frag"
    (redGreen, orangeBlue)

let setup p5 (redGreen, orangeBlue) =
    createWebGLCanvas p5 100 100

    // initialize the colors for redGreen shader
    shader p5 redGreen
    redGreen.setUniform "colorCenter" (ResizeArray [ 1.0; 0.0; 0.0 ])
    redGreen.setUniform "colorBackground" (ResizeArray [ 0.0; 1.0; 0.0 ])

    // initialize the colors for orangeBlue shader
    shader p5 orangeBlue
    orangeBlue.setUniform "colorCenter" (ResizeArray [ 1.0; 0.5; 0.0 ])
    orangeBlue.setUniform "colorBackground" (ResizeArray [ 0.226; 0.0; 0.615 ])

    noStroke p5

    { redGreen = redGreen
      orangeBlue = orangeBlue
      showRedGreen = true }

let draw p5 state =
    let t = (millis p5 |> float) / 2000.0

    // update the offset values for each shader,
    // moving orangeBlue in vertical and redGreen
    // in horizontal direction
    state.orangeBlue.setUniform "offset" (ResizeArray [ 0.0; sin t + 1.0 ])
    state.redGreen.setUniform "offset" (ResizeArray [ sin t; 1.0 ])

    if state.showRedGreen then
        do shader p5 state.redGreen
    else
        shader p5 state.orangeBlue

    quad p5 -1 -1 1 -1 1 1 -1 1

let onClick _ _ state =
    { state with showRedGreen = not state.showRedGreen }

let subscriptions = [ OnMouseClicked(Update onClick) ]

let run node =
    playWithPreload node preload setup noUpdate draw subscriptions
