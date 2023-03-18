#!/usr/bin/env bash
set -e

# The idea is to fill in the sketch details in the fsproj, then run this command
# to generate dummy sketch files. The updated App.fs contents are copied to the
# clipboard.

cat src/PerfectFifth.Reference/PerfectFifth-Reference.fsproj \
    | grep -oP "Compile Include=\"\K[^\.]+" \
    | grep -v "^App$" \
    | sed 's/\([a-zA-Z]*\).\([a-zA-Z0-9]*\)/\1 \2/' \
    | xargs -n 2 sh -c '
        mkdir -p src/PerfectFifth.Reference/$0 \
        && cp -u scripts/reference-template.fs src/PerfectFifth.Reference/$0/$1.fs \
        && sed -i "s/SECTION/$0/" src/PerfectFifth.Reference/$0/$1.fs \
        && sed -i s/SKETCHNAME/$1/ src/PerfectFifth.Reference/$0/$1.fs
      '

cat src/PerfectFifth.Reference/PerfectFifth-Reference.fsproj \
    | grep -oP "Compile Include=\"\K[^\.]+" \
    | grep -v "^App$" \
    | sed 's/\([a-zA-Z]*\).\([a-zA-Z0-9]*\)/| "\1\/\2" -> \1.\2.run node/' \
    | xclip -selection clipboard

echo "App.fs contents copied to clipboard!"
