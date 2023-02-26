namespace P5

module Core =

    open Fable.Core

    type P5 =
        class
        end

    type Event = MouseMoved

    type Node =
        | Selector of string // @todo: doesn't work yet.
        | Element of Browser.Types.Element
        | None

    // Inspired by Quil's fun-mode and Gloss.
    type Sketch<'a> =
        { initial: 'a
          setup: P5 -> Unit
          update: P5 -> 'a -> 'a
          draw: P5 -> 'a -> Unit
          eventHandler: P5 -> Event -> 'a -> 'a
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
    let createSketch (sketch: Sketch<'a>) : Unit = jsNative

    let noSetup (_: P5) = ()

    /// Create a static sketch.
    let display (node: Node) (draw: P5 -> Unit) : Unit =
        let setupWithLoopDisabled (p5: P5) = noLoop p5

        let drawDropState (p5: P5) _ = draw p5

        createSketch
            { defaultSketch () with
                setup = setupWithLoopDisabled
                draw = drawDropState
                node = node }

    /// Create a simple animation sketch, which draws something based on the
    /// time elapsed.
    let animate (node: Node) (setup: P5 -> Unit) (draw: P5 -> int -> Unit) : Unit =
        let drawWithTimeElapsed (p5: P5) _ = draw p5 (millis p5)

        createSketch
            { defaultSketch () with
                setup = setup
                draw = drawWithTimeElapsed
                node = node }

    /// Create a simulation sketch. It starts with an initial state, which gets
    /// updated every step.
    let simulate
        (node: Node)
        (initial: 'a)
        (setup: P5 -> Unit)
        (update: P5 -> 'a -> 'a)
        (draw: P5 -> 'a -> Unit)
        : Unit =
        createSketch
            { defaultSketch initial with
                setup = setup
                update = update
                draw = draw
                node = node }

    /// Create a sketch with all functionality: handling state and events.
    let play
        (node: Node)
        (initial: 'a)
        (setup: P5 -> Unit)
        (update: P5 -> 'a -> 'a)
        (draw: P5 -> 'a -> Unit)
        (eventHandler: P5 -> Event -> 'a -> 'a)
        : Unit =
        createSketch
            { initial = initial
              setup = setup
              update = update
              draw = draw
              eventHandler = eventHandler
              node = node }
