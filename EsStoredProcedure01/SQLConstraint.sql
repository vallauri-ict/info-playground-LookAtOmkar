ALTER TABLE filiali
ADD CONSTRAINT [FK_filiali_banche] FOREIGN KEY (IdBanca) REFERENCES banche(Id)