CREATE TRIGGER Aggiornamento
	ON [dbo].[Driver]
	AFTER UPDATE
	AS
	BEGIN
		INSERT INTO StoricoAggiornamenti (
		[id],
		[idStoricoAggiornamenti],
		[NomeCampo],
		[ValoreCampoOld],
		[ValoreCampoNew]
		)
		(SELECT *,GETDATE() FROM deleted d, inserted i
		WHERE d.number = i.number)
	END