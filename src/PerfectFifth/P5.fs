namespace P5

module Core =

    open Fable.Core

    type P5 =
        class
        end

    type Event = MouseMoved

    type Initial<'a> = 'a

    type Setup = P5 -> Unit

    type Update<'a> = P5 -> 'a -> 'a

    type Draw<'a> = P5 -> 'a -> Unit

    type EventHandler<'a> = P5 -> Event -> 'a -> 'a

    type Node =
        | Selector of string
        | Element of string // @todo: element instead of string
        | None

    // Inspired by Quil's fun-mode and Gloss.
    type Sketch<'a> =
        { initial: Initial<'a>
          setup: Setup
          update: Update<'a>
          draw: Draw<'a>
          eventHandler: EventHandler<'a>
          node: Node }

    /// Disables the draw function from being called continuously. This should
    /// belong in P5.Structure, but because we need this in `display`, we would
    /// run into dependency issues.
    [<Emit("$0.noLoop()")>]
    let noLoop (p5: P5) : Unit = jsNative

    /// Returns the time in milliseconds since the start of the sketch. This
    /// should belong in P5.Time, but because we need this in `animate`, we
    /// would run into dependency issues.
    [<Emit("$0.millis()")>]
    let millis (p5: P5) : int = jsNative

    let defaultSketch initial =
        { initial = initial
          setup = (fun _ -> ())
          update = (fun _ -> id)
          draw = (fun _ _ -> ())
          eventHandler = (fun _ _ -> id)
          node = None }

    [<ImportMember("./sketch.js")>]
    let createSketch (sketch: Sketch<'a>) = jsNative

    let noSetup (_: P5) = ()

    /// Create a static sketch.
    let display (setup: Setup) (draw: P5 -> Unit) =
        let setupWithLoopDisabled (p5: P5) =
            setup p5
            noLoop p5

        let drawDropState (p5: P5) _ = draw p5

        createSketch
            { defaultSketch () with
                setup = setupWithLoopDisabled
                draw = drawDropState }

    /// Create a simple animation sketch, which draws something based on the
    /// time elapsed.
    let animate (setup: Setup) (draw: P5 -> int -> Unit) =
        let drawWithTimeElapsed (p5: P5) _ = draw p5 (millis p5)

        createSketch
            { defaultSketch () with
                setup = setup
                draw = drawWithTimeElapsed }

    /// Create a simulation sketch. It starts with an initial state, which gets
    /// updated every step.
    let simulate (initial: 'a) (setup: Setup) (update: Update<'a>) (draw: Draw<'a>) =
        createSketch
            { defaultSketch initial with
                setup = setup
                update = update
                draw = draw }

    /// Create a sketch with all functionality: handling state and events.
    let play (initial: 'a) (setup: Setup) (update: Update<'a>) (draw: Draw<'a>) (eventHandler: EventHandler<'a>) =
        createSketch
            { defaultSketch initial with
                setup = setup
                update = update
                draw = draw
                eventHandler = eventHandler }
