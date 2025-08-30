namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class banco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipe_Lab",
                c => new
                    {
                        ID_FUNCIONÁRIO = c.Long(nullable: false, identity: true),
                        ID_FUNCIONARIO_CRIADOR_EQUIPE = c.Long(nullable: false),
                        ID_FUNCIONARIO_EDITOR_EQUIPE = c.Long(nullable: false),
                        CPF_FUNCIONÁRIO = c.String(),
                        MATRICULA_FUNCIONÁRIO = c.String(),
                        CARGO_FUNCIONÁRIO = c.String(),
                        StatusEquipe = c.String(),
                        NOME_FUNCIONÁRIO = c.String(),
                        EMAIL_FUNCIONÁRIO = c.String(),
                        CELULAR_FUNCIONÁRIO = c.String(),
                        SENHA_FUNCIONÁRIO = c.String(),
                        SALT_FUNCIONÁRIO = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_FUNCIONÁRIO);
            
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        ID_PEDIDO = c.Long(nullable: false, identity: true),
                        ID_SOLICITANTE = c.Long(nullable: false),
                        ID_FUNCIONARIO_CRIADOR_PEDIDO = c.Long(nullable: false),
                        ID_PRODUTO = c.Long(nullable: false),
                        ID_TIPO_SERVICO = c.Long(nullable: false),
                        ID_FUNCIONARIO_EDITOR_PEDIDO = c.Long(nullable: false),
                        DATA_PEDIDO = c.DateTime(nullable: false),
                        ORDEM_SERVICO = c.String(),
                        STATUS_PEDIDO = c.String(),
                        OBSERVACAO_PEDIDO = c.String(),
                    })
                .PrimaryKey(t => t.ID_PEDIDO);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ID_PRODUTO = c.Long(nullable: false, identity: true),
                        ID_SOLICITANTE = c.Long(nullable: false),
                        ID_FUNCIONARIO_CRIADOR_PRODUTO = c.Long(nullable: false),
                        ID_FUNCIONARIO_EDITOR_PRODUTO = c.Long(nullable: false),
                        NOME_PRODUTO = c.String(),
                        PESO_PRODUTO = c.Double(nullable: false),
                        MODELO_PRODUTO = c.String(),
                        STATUS_PRODUTO = c.String(),
                        TIPO_PRODUTO = c.String(),
                    })
                .PrimaryKey(t => t.ID_PRODUTO);
            
            CreateTable(
                "dbo.Servico",
                c => new
                    {
                        ID_SERVICO = c.Long(nullable: false, identity: true),
                        STATUS_SERVICO = c.String(),
                        ID_FUNCIONARIO_CRIADOR_SERVICO = c.Long(nullable: false),
                        ID_FUNCIONARIO_EDITOR_SERVICO = c.Long(nullable: false),
                        DETALHES_SERVICO = c.String(),
                        ID_TIPO_SERVICO = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID_SERVICO);
            
            CreateTable(
                "dbo.Solicitacoes",
                c => new
                    {
                        ID_FUNCIONÁRIO_SOLICITANTE = c.Long(nullable: false, identity: true),
                        ID_FUNCIONARIO_EDITOR_SOLICITACOES = c.Long(nullable: false),
                        CPF_FUNCIONÁRIO_SOLICITANTE = c.String(),
                        STATUS_FUNCIONÁRIO_SOLICITANTE = c.String(),
                        NOME_FUNCIONÁRIO_SOLICITANTE = c.String(),
                        EMAIL_FUNCIONÁRIO_SOLICITANTE = c.String(),
                        CELULAR_FUNCIONÁRIO_SOLICITANTE = c.String(),
                        SENHA_FUNCIONÁRIO_SOLICITANTE = c.String(),
                        SALT_FUNCIONÁRIO_SOLICITANTE = c.String(),
                    })
                .PrimaryKey(t => t.ID_FUNCIONÁRIO_SOLICITANTE);
            
            CreateTable(
                "dbo.Solicitante",
                c => new
                    {
                        ID_SOLICITANTE = c.Long(nullable: false, identity: true),
                        NOME_SOLICITANTE = c.String(),
                        EMAIL_SOLICITANTE = c.String(),
                        CELULAR_SOLICITADOR = c.String(),
                        ID_FUNCIONARIO_CRIADOR_SOLICITANTE = c.Long(nullable: false),
                        ID_FUNCIONARIO_EDITOR_SOLICITANTE = c.Long(nullable: false),
                        STATUS_SOLICITANTE = c.String(),
                        DOCUMENTO_SOLICITANTE = c.String(),
                    })
                .PrimaryKey(t => t.ID_SOLICITANTE);
            
            CreateTable(
                "dbo.Tipo_Servico",
                c => new
                    {
                        ID_TIPO_SERVICO = c.Long(nullable: false, identity: true),
                        ID_FUNCIONARIO_CRIADOR_TIPO_SERVICO = c.Long(nullable: false),
                        ID_FUNCIONARIO_EDITOR_TIPO_SERVICO = c.Long(nullable: false),
                        NOME_TIPO_SERVICO = c.String(),
                        STATUS_TIPO_SERVICO = c.String(),
                        DETALHE_TIPO_SERVICO = c.String(),
                    })
                .PrimaryKey(t => t.ID_TIPO_SERVICO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tipo_Servico");
            DropTable("dbo.Solicitante");
            DropTable("dbo.Solicitacoes");
            DropTable("dbo.Servico");
            DropTable("dbo.Produto");
            DropTable("dbo.Pedido");
            DropTable("dbo.Equipe_Lab");
        }
    }
}
