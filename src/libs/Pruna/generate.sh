#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Pruna \
  --clientClassName PrunaClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:apikey \
  --exclude-deprecated-operations
