# TODO: Resolver erro de compilação e problema de destaque de erros no VS Code

## Passos executados:

- [x] Corrigir erro de compilação em Diretor.cs: Adicionado construtor que chama base com parâmetro 'nome' para satisfazer o construtor de Professor.
- [x] Testar compilação com `dotnet build` para confirmar correção. (Compilação bem-sucedida.)
- [ ] Verificar se o VS Code agora destaca erros em tempo real no editor.
- [ ] Se ainda não destacar, aplicar soluções para OmniSharp/Extensão C#:
  - Reiniciar VS Code ou recarregar janela (Ctrl+Shift+P > "Developer: Reload Window").
  - Verificar se extensão C# (OmniSharp) está instalada e atualizada (versão mais recente).
  - Verificar status do OmniSharp na barra de status (ícone de chama deve estar verde).
  - Abrir o arquivo .sln ou .csproj no VS Code para garantir reconhecimento do projeto.
  - Limpar cache do OmniSharp: Ctrl+Shift+P > "OmniSharp: Restart OmniSharp" ou "OmniSharp: Clear Cache".
  - Verificar configurações: Arquivo > Preferências > Configurações > Pesquisar "omnisharp" e garantir que "OmniSharp: Enable Editor Config Support" e "OmniSharp: Enable Roslyn Analyzers" estejam habilitados.
  - Se necessário, desinstalar e reinstalar a extensão C#.
- [ ] Testar novamente após soluções aplicadas.
