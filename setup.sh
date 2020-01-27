#!/bin/sh

if [ "$#" -ne 1 ]; then
    echo "usage: $0 <plugin name>"
    exit 1
fi

bpsub="Boilerplate"
myplugin=$1

echo "setting up $myplugin plugin..."

echo "renaming directories..."
dirs=`find . -type d -name "*${bpsub}*"`
for d in $dirs; do
    mv -v $d "${d//$bpsub/$myplugin}"
done

echo "renaming and preparing files..."
files=`find . -type f -name "*${bpsub}*"`
for f in $files; do
    echo "fixing module name for $f..."
    sed -i '' "s/<#Module Name#>/${myplugin}/g" $f
    sed -i '' "s/<#generation date#>/$(date +'%B %d %Y')/g" $f
    mv -v $f "${f//$bpsub/$myplugin}"
done

echo "done."
