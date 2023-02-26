#!/usr/bin/env sh
npm run build
python3 gh-pages/generate.py
cp public/bundle.js gh-pages/output
python3 -m http.server -d gh-pages/output
