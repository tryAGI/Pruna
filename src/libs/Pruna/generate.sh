#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Pruna \
  --clientClassName PrunaClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:apikey \
  --exclude-deprecated-operations

rm -rf ../../cli/Pruna.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Pruna.CLI \
  --sdk-project ../../libs/Pruna/Pruna.csproj \
  --targetFramework net10.0 \
  --namespace Pruna \
  --clientClassName PrunaClient \
  --package-id Pruna.CLI \
  --tool-command-name pruna \
  --user-secrets-id Pruna.CLI \
  --api-key-env-var PRUNA_API_KEY \
  --base-url-env-var PRUNA_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:apikey
