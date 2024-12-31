using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Reporteadores.Models;

public partial class BarronContext : DbContext
{
    public BarronContext()
    {
    }

    public BarronContext(DbContextOptions<BarronContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcarAbo> AcarAbos { get; set; }

    public virtual DbSet<Acceslog> Acceslogs { get; set; }

    public virtual DbSet<Accident> Accidents { get; set; }

    public virtual DbSet<Accion> Accions { get; set; }

    public virtual DbSet<Accregla> Accreglas { get; set; }

    public virtual DbSet<Acumula> Acumulas { get; set; }

    public virtual DbSet<Aguinal> Aguinals { get; set; }

    public virtual DbSet<AhoPre> AhoPres { get; set; }

    public virtual DbSet<Ahorro> Ahorros { get; set; }

    public virtual DbSet<Altabaja> Altabajas { get; set; }

    public virtual DbSet<Antescur> Antescurs { get; set; }

    public virtual DbSet<Antespto> Antesptos { get; set; }

    public virtual DbSet<ArTemCur> ArTemCurs { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Art80> Art80s { get; set; }

    public virtual DbSet<AsientoContable> AsientoContables { get; set; }

    public virtual DbSet<Asigna> Asignas { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Ausencium> Ausencia { get; set; }

    public virtual DbSet<Bitacora> Bitacoras { get; set; }

    public virtual DbSet<Break> Breaks { get; set; }

    public virtual DbSet<BrkHora> BrkHoras { get; set; }

    public virtual DbSet<CafCome> CafComes { get; set; }

    public virtual DbSet<CafInv> CafInvs { get; set; }

    public virtual DbSet<Cafregla> Cafreglas { get; set; }

    public virtual DbSet<Calcurso> Calcursos { get; set; }

    public virtual DbSet<Califica> Calificas { get; set; }

    public virtual DbSet<CampoAd> CampoAds { get; set; }

    public virtual DbSet<CampoEx> CampoExes { get; set; }

    public virtual DbSet<Camporep> Camporeps { get; set; }

    public virtual DbSet<Causacci> Causaccis { get; set; }

    public virtual DbSet<Ccurso> Ccursos { get; set; }

    public virtual DbSet<CedEmp> CedEmps { get; set; }

    public virtual DbSet<CedInsp> CedInsps { get; set; }

    public virtual DbSet<CedWord> CedWords { get; set; }

    public virtual DbSet<Cedscrap> Cedscraps { get; set; }

    public virtual DbSet<Cedula> Cedulas { get; set; }

    public virtual DbSet<CerProg> CerProgs { get; set; }

    public virtual DbSet<Cernivel> Cernivels { get; set; }

    public virtual DbSet<Certific> Certifics { get; set; }

    public virtual DbSet<Checada> Checadas { get; set; }

    public virtual DbSet<Clasifi> Clasifis { get; set; }

    public virtual DbSet<Clasitmp> Clasitmps { get; set; }

    public virtual DbSet<Colabora> Colaboras { get; set; }

    public virtual DbSet<Colonium> Colonia { get; set; }

    public virtual DbSet<CompCal> CompCals { get; set; }

    public virtual DbSet<CompFam> CompFams { get; set; }

    public virtual DbSet<CompMap> CompMaps { get; set; }

    public virtual DbSet<CompPto> CompPtos { get; set; }

    public virtual DbSet<Compara> Comparas { get; set; }

    public virtual DbSet<Competen> Competens { get; set; }

    public virtual DbSet<Componen> Componens { get; set; }

    public virtual DbSet<Concepto> Conceptos { get; set; }

    public virtual DbSet<ConceptosSat> ConceptosSats { get; set; }

    public virtual DbSet<Consultum> Consulta { get; set; }

    public virtual DbSet<Conteo> Conteos { get; set; }

    public virtual DbSet<ContraCuenta> ContraCuentas { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<CtaMov> CtaMovs { get; set; }

    public virtual DbSet<Ctabanco> Ctabancos { get; set; }

    public virtual DbSet<CurAsi> CurAses { get; set; }

    public virtual DbSet<CurProg> CurProgs { get; set; }

    public virtual DbSet<CurRev> CurRevs { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Cursopre> Cursopres { get; set; }

    public virtual DbSet<Declara> Declaras { get; set; }

    public virtual DbSet<DefectV> DefectVs { get; set; }

    public virtual DbSet<Defecto> Defectos { get; set; }

    public virtual DbSet<Defstep> Defsteps { get; set; }

    public virtual DbSet<DescFld> DescFlds { get; set; }

    public virtual DbSet<DescPto> DescPtos { get; set; }

    public virtual DbSet<Desctipo> Desctipos { get; set; }

    public virtual DbSet<Diagnost> Diagnosts { get; set; }

    public virtual DbSet<Diccion> Diccions { get; set; }

    public virtual DbSet<Dimensio> Dimensios { get; set; }

    public virtual DbSet<Edocivil> Edocivils { get; set; }

    public virtual DbSet<Embarazo> Embarazos { get; set; }

    public virtual DbSet<EmpComp> EmpComps { get; set; }

    public virtual DbSet<EmpPlan> EmpPlans { get; set; }

    public virtual DbSet<EmpProg> EmpProgs { get; set; }

    public virtual DbSet<EmpleadosXVerificar> EmpleadosXVerificars { get; set; }

    public virtual DbSet<EntNac> EntNacs { get; set; }

    public virtual DbSet<Entfed> Entfeds { get; set; }

    public virtual DbSet<Entidad> Entidads { get; set; }

    public virtual DbSet<Entnivel> Entnivels { get; set; }

    public virtual DbSet<Entrena> Entrenas { get; set; }

    public virtual DbSet<Establec> Establecs { get; set; }

    public virtual DbSet<Estudio> Estudios { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Expedien> Expediens { get; set; }

    public virtual DbSet<Extra1> Extra1s { get; set; }

    public virtual DbSet<Extra10> Extra10s { get; set; }

    public virtual DbSet<Extra11> Extra11s { get; set; }

    public virtual DbSet<Extra12> Extra12s { get; set; }

    public virtual DbSet<Extra13> Extra13s { get; set; }

    public virtual DbSet<Extra14> Extra14s { get; set; }

    public virtual DbSet<Extra2> Extra2s { get; set; }

    public virtual DbSet<Extra3> Extra3s { get; set; }

    public virtual DbSet<Extra4> Extra4s { get; set; }

    public virtual DbSet<Extra5> Extra5s { get; set; }

    public virtual DbSet<Extra6> Extra6s { get; set; }

    public virtual DbSet<Extra7> Extra7s { get; set; }

    public virtual DbSet<Extra8> Extra8s { get; set; }

    public virtual DbSet<Extra9> Extra9s { get; set; }

    public virtual DbSet<Falta> Faltas { get; set; }

    public virtual DbSet<FamPto> FamPtos { get; set; }

    public virtual DbSet<Festivo> Festivos { get; set; }

    public virtual DbSet<Folio> Folios { get; set; }

    public virtual DbSet<FonCre> FonCres { get; set; }

    public virtual DbSet<FonEmp> FonEmps { get; set; }

    public virtual DbSet<FonTot> FonTots { get; set; }

    public virtual DbSet<Global> Globals { get; set; }

    public virtual DbSet<GrAdAcc> GrAdAccs { get; set; }

    public virtual DbSet<GrupoAd> GrupoAds { get; set; }

    public virtual DbSet<GrupoEx> GrupoExes { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Horario1> Horarios1 { get; set; }

    public virtual DbSet<HorarioPersonal> HorarioPersonals { get; set; }

    public virtual DbSet<Imagen> Imagens { get; set; }

    public virtual DbSet<Incapaci> Incapacis { get; set; }

    public virtual DbSet<Inciden> Incidens { get; set; }

    public virtual DbSet<Inscrito> Inscritos { get; set; }

    public virtual DbSet<Invitum> Invita { get; set; }

    public virtual DbSet<Jornada> Jornadas { get; set; }

    public virtual DbSet<KarArea> KarAreas { get; set; }

    public virtual DbSet<KarCert> KarCerts { get; set; }

    public virtual DbSet<KarFija> KarFijas { get; set; }

    public virtual DbSet<KarTool> KarTools { get; set; }

    public virtual DbSet<Karcurso> Karcursos { get; set; }

    public virtual DbSet<Kardex> Kardices { get; set; }

    public virtual DbSet<Karinf> Karinfs { get; set; }

    public virtual DbSet<LCalculo> LCalculos { get; set; }

    public virtual DbSet<Lectura> Lecturas { get; set; }

    public virtual DbSet<LeyImss> LeyImsses { get; set; }

    public virtual DbSet<LiqEmp> LiqEmps { get; set; }

    public virtual DbSet<LiqImss> LiqImsses { get; set; }

    public virtual DbSet<LiqMov> LiqMovs { get; set; }

    public virtual DbSet<Maestro> Maestros { get; set; }

    public virtual DbSet<MedEntr> MedEntrs { get; set; }

    public virtual DbSet<Medicina> Medicinas { get; set; }

    public virtual DbSet<Misrepor> Misrepors { get; set; }

    public virtual DbSet<Modula1> Modula1s { get; set; }

    public virtual DbSet<Modula2> Modula2s { get; set; }

    public virtual DbSet<Modula3> Modula3s { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<MotAuto> MotAutos { get; set; }

    public virtual DbSet<MotBaja> MotBajas { get; set; }

    public virtual DbSet<MotBajaIdse> MotBajaIdses { get; set; }

    public virtual DbSet<MotCheca> MotChecas { get; set; }

    public virtual DbSet<MotTool> MotTools { get; set; }

    public virtual DbSet<Motacci> Motaccis { get; set; }

    public virtual DbSet<Motscrap> Motscraps { get; set; }

    public virtual DbSet<MovGral> MovGrals { get; set; }

    public virtual DbSet<Movimien> Movimiens { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    public virtual DbSet<NavDato> NavDatos { get; set; }

    public virtual DbSet<NavimssDato> NavimssDatos { get; set; }

    public virtual DbSet<NavimssDatosbn> NavimssDatosbns { get; set; }

    public virtual DbSet<NivDime> NivDimes { get; set; }

    public virtual DbSet<NivPto> NivPtos { get; set; }

    public virtual DbSet<Nivel1> Nivel1s { get; set; }

    public virtual DbSet<Nivel2> Nivel2s { get; set; }

    public virtual DbSet<Nivel3> Nivel3s { get; set; }

    public virtual DbSet<Nivel4> Nivel4s { get; set; }

    public virtual DbSet<Nivel5> Nivel5s { get; set; }

    public virtual DbSet<Nivel6> Nivel6s { get; set; }

    public virtual DbSet<Nivel7> Nivel7s { get; set; }

    public virtual DbSet<Nivel8> Nivel8s { get; set; }

    public virtual DbSet<Nivel9> Nivel9s { get; set; }

    public virtual DbSet<Nomina> Nominas { get; set; }

    public virtual DbSet<Nomparam> Nomparams { get; set; }

    public virtual DbSet<Numerica> Numericas { get; set; }

    public virtual DbSet<OcupaNac> OcupaNacs { get; set; }

    public virtual DbSet<Opera> Operas { get; set; }

    public virtual DbSet<Ordfolio> Ordfolios { get; set; }

    public virtual DbSet<Otrasper> Otraspers { get; set; }

    public virtual DbSet<Pariente> Parientes { get; set; }

    public virtual DbSet<Parte> Partes { get; set; }

    public virtual DbSet<PcarAbo> PcarAbos { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Plaza> Plazas { get; set; }

    public virtual DbSet<PolHead> PolHeads { get; set; }

    public virtual DbSet<PolTipo> PolTipos { get; set; }

    public virtual DbSet<Poliza> Polizas { get; set; }

    public virtual DbSet<Prestaci> Prestacis { get; set; }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<Prestaxreg> Prestaxregs { get; set; }

    public virtual DbSet<Priesgo> Priesgos { get; set; }

    public virtual DbSet<Proceso> Procesos { get; set; }

    public virtual DbSet<ProvCap> ProvCaps { get; set; }

    public virtual DbSet<PtoCert> PtoCerts { get; set; }

    public virtual DbSet<PtoDime> PtoDimes { get; set; }

    public virtual DbSet<Ptofija> Ptofijas { get; set; }

    public virtual DbSet<Ptotool> Ptotools { get; set; }

    public virtual DbSet<Puesto> Puestos { get; set; }

    public virtual DbSet<Query> Querys { get; set; }

    public virtual DbSet<RAtributo> RAtributos { get; set; }

    public virtual DbSet<RClasAcc> RClasAccs { get; set; }

    public virtual DbSet<RClasEnt> RClasEnts { get; set; }

    public virtual DbSet<RClasifi> RClasifis { get; set; }

    public virtual DbSet<RDatosdef> RDatosdefs { get; set; }

    public virtual DbSet<RDefault> RDefaults { get; set; }

    public virtual DbSet<REntAcc> REntAccs { get; set; }

    public virtual DbSet<REntidad> REntidads { get; set; }

    public virtual DbSet<RFiltro> RFiltros { get; set; }

    public virtual DbSet<RListaval> RListavals { get; set; }

    public virtual DbSet<RModEnt> RModEnts { get; set; }

    public virtual DbSet<RModulo> RModulos { get; set; }

    public virtual DbSet<ROrden> ROrdens { get; set; }

    public virtual DbSet<RRelacion> RRelacions { get; set; }

    public virtual DbSet<RValor> RValors { get; set; }

    public virtual DbSet<Reglaprest> Reglaprests { get; set; }

    public virtual DbSet<RepAho> RepAhos { get; set; }

    public virtual DbSet<RepEmp> RepEmps { get; set; }

    public virtual DbSet<RepPtu> RepPtus { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Riesgo> Riesgos { get; set; }

    public virtual DbSet<Rpatron> Rpatrons { get; set; }

    public virtual DbSet<Rsocial> Rsocials { get; set; }

    public virtual DbSet<SalMin> SalMins { get; set; }

    public virtual DbSet<Scrap> Scraps { get; set; }

    public virtual DbSet<ScrapV> ScrapVs { get; set; }

    public virtual DbSet<Sesion> Sesions { get; set; }

    public virtual DbSet<Ssocial> Ssocials { get; set; }

    public virtual DbSet<Step> Steps { get; set; }

    public virtual DbSet<SupArea> SupAreas { get; set; }

    public virtual DbSet<Super> Supers { get; set; }

    public virtual DbSet<Suscrip> Suscrips { get; set; }

    public virtual DbSet<TArt80> TArt80s { get; set; }

    public virtual DbSet<Tacciden> Taccidens { get; set; }

    public virtual DbSet<Tahorro> Tahorros { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    public virtual DbSet<Tcambio> Tcambios { get; set; }

    public virtual DbSet<Tcompete> Tcompetes { get; set; }

    public virtual DbSet<Tconsltum> Tconslta { get; set; }

    public virtual DbSet<Tctamov> Tctamovs { get; set; }

    public virtual DbSet<Tcurso> Tcursos { get; set; }

    public virtual DbSet<Tdefecto> Tdefectos { get; set; }

    public virtual DbSet<Testudio> Testudios { get; set; }

    public virtual DbSet<Tfija> Tfijas { get; set; }

    public virtual DbSet<Tkardex> Tkardices { get; set; }

    public virtual DbSet<Tmpbala2> Tmpbala2s { get; set; }

    public virtual DbSet<Tmpbalan> Tmpbalans { get; set; }

    public virtual DbSet<Tmpcalen> Tmpcalens { get; set; }

    public virtual DbSet<Tmpcalhr> Tmpcalhrs { get; set; }

    public virtual DbSet<Tmpdemo> Tmpdemos { get; set; }

    public virtual DbSet<Tmpdimm> Tmpdimms { get; set; }

    public virtual DbSet<Tmpdimmtot> Tmpdimmtots { get; set; }

    public virtual DbSet<Tmpestad> Tmpestads { get; set; }

    public virtual DbSet<Tmpevent> Tmpevents { get; set; }

    public virtual DbSet<Tmpfolio> Tmpfolios { get; set; }

    public virtual DbSet<Tmphora> Tmphoras { get; set; }

    public virtual DbSet<Tmplabor> Tmplabors { get; set; }

    public virtual DbSet<Tmplistum> Tmplista { get; set; }

    public virtual DbSet<Tmpmov> Tmpmovs { get; set; }

    public virtual DbSet<Tmpnom> Tmpnoms { get; set; }

    public virtual DbSet<Tmppromvar> Tmppromvars { get; set; }

    public virtual DbSet<Tmprotai> Tmprotais { get; set; }

    public virtual DbSet<Tmprotum> Tmprota { get; set; }

    public virtual DbSet<Tmpsalar> Tmpsalars { get; set; }

    public virtual DbSet<Tmptotal> Tmptotals { get; set; }

    public virtual DbSet<Tmuerto> Tmuertos { get; set; }

    public virtual DbSet<Tool> Tools { get; set; }

    public virtual DbSet<Topera> Toperas { get; set; }

    public virtual DbSet<Tparte> Tpartes { get; set; }

    public virtual DbSet<Tperiodo> Tperiodos { get; set; }

    public virtual DbSet<Tprestum> Tpresta { get; set; }

    public virtual DbSet<Transpor> Transpors { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<UltimoEmpleado> UltimoEmpleados { get; set; }

    public virtual DbSet<Uma> Umas { get; set; }

    public virtual DbSet<Umi> Umis { get; set; }

    public virtual DbSet<VAccAd> VAccAds { get; set; }

    public virtual DbSet<VAccDer> VAccDers { get; set; }

    public virtual DbSet<VAccRdd> VAccRdds { get; set; }

    public virtual DbSet<VAccall> VAccalls { get; set; }

    public virtual DbSet<VAccarbol> VAccarbols { get; set; }

    public virtual DbSet<VAccemp> VAccemps { get; set; }

    public virtual DbSet<VAcceso> VAccesos { get; set; }

    public virtual DbSet<VAccusu> VAccusus { get; set; }

    public virtual DbSet<VAcumula> VAcumulas { get; set; }

    public virtual DbSet<VAdvanceitEmpleado> VAdvanceitEmpleados { get; set; }

    public virtual DbSet<VAdvanceitEmpresa> VAdvanceitEmpresas { get; set; }

    public virtual DbSet<VBitacora> VBitacoras { get; set; }

    public virtual DbSet<VBitcafe> VBitcaves { get; set; }

    public virtual DbSet<VBitcafee> VBitcafees { get; set; }

    public virtual DbSet<VBitkiosc> VBitkioscs { get; set; }

    public virtual DbSet<VCedWord> VCedWords { get; set; }

    public virtual DbSet<VCoXGr> VCoXGrs { get; set; }

    public virtual DbSet<VCompany> VCompanies { get; set; }

    public virtual DbSet<VConSat> VConSats { get; set; }

    public virtual DbSet<VConceptosAbg> VConceptosAbgs { get; set; }

    public virtual DbSet<VConceptosSat> VConceptosSats { get; set; }

    public virtual DbSet<VContraCuenta> VContraCuentas { get; set; }

    public virtual DbSet<VCurso> VCursos { get; set; }

    public virtual DbSet<VDisposit> VDisposits { get; set; }

    public virtual DbSet<VDisxcom> VDisxcoms { get; set; }

    public virtual DbSet<VEntfedAbg> VEntfedAbgs { get; set; }

    public virtual DbSet<VGlobalAbg> VGlobalAbgs { get; set; }

    public virtual DbSet<VGradall> VGradalls { get; set; }

    public virtual DbSet<VGrupo> VGrupos { get; set; }

    public virtual DbSet<VLiqEmp> VLiqEmps { get; set; }

    public virtual DbSet<VMotBajaIdse> VMotBajaIdses { get; set; }

    public virtual DbSet<VNavDato> VNavDatos { get; set; }

    public virtual DbSet<VNavimssDato> VNavimssDatos { get; set; }

    public virtual DbSet<VNavimssDatosbn> VNavimssDatosbns { get; set; }

    public virtual DbSet<VNivel0> VNivel0s { get; set; }

    public virtual DbSet<VPoll> VPolls { get; set; }

    public virtual DbSet<VPrinter> VPrinters { get; set; }

    public virtual DbSet<VRclaall> VRclaalls { get; set; }

    public virtual DbSet<VRentall> VRentalls { get; set; }

    public virtual DbSet<VReporte> VReportes { get; set; }

    public virtual DbSet<VTurnoAbg> VTurnoAbgs { get; set; }

    public virtual DbSet<VUmaAbg> VUmaAbgs { get; set; }

    public virtual DbSet<VUmiAbg> VUmiAbgs { get; set; }

    public virtual DbSet<VUsuario> VUsuarios { get; set; }

    public virtual DbSet<VValPto> VValPtos { get; set; }

    public virtual DbSet<VValplant> VValplants { get; set; }

    public virtual DbSet<VVfactor> VVfactors { get; set; }

    public virtual DbSet<VVpunto> VVpuntos { get; set; }

    public virtual DbSet<VVsubfact> VVsubfacts { get; set; }

    public virtual DbSet<Vacacion> Vacacions { get; set; }

    public virtual DbSet<Vacaplan> Vacaplans { get; set; }

    public virtual DbSet<ValPto> ValPtos { get; set; }

    public virtual DbSet<Valnivel> Valnivels { get; set; }

    public virtual DbSet<Valplant> Valplants { get; set; }

    public virtual DbSet<Vfactor> Vfactors { get; set; }

    public virtual DbSet<ViveCon> ViveCons { get; set; }

    public virtual DbSet<ViveEn> ViveEns { get; set; }

    public virtual DbSet<Vpunto> Vpuntos { get; set; }

    public virtual DbSet<Vsubfact> Vsubfacts { get; set; }

    public virtual DbSet<Wofija> Wofijas { get; set; }

    public virtual DbSet<Worder> Worders { get; set; }

    public virtual DbSet<Work> Works { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.101.100; Initial Catalog=BARRON; MultipleActiveResultSets=True; User ID=sa; Password=Admin_sqlABG; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcarAbo>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AhTipo, e.CrFecha });

            entity.ToTable("ACAR_ABO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AhTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AH_TIPO");
            entity.Property(e => e.CrFecha)
                .HasColumnType("datetime")
                .HasColumnName("CR_FECHA");
            entity.Property(e => e.CrAbono)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CR_ABONO");
            entity.Property(e => e.CrCaptura)
                .HasColumnType("datetime")
                .HasColumnName("CR_CAPTURA");
            entity.Property(e => e.CrCargo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CR_CARGO");
            entity.Property(e => e.CrObserva)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CR_OBSERVA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.Ahorro).WithMany(p => p.AcarAbos)
                .HasForeignKey(d => new { d.CbCodigo, d.AhTipo })
                .HasConstraintName("FK_ACar_ABo_Ahorro");
        });

        modelBuilder.Entity<Acceslog>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AlFecha, e.AlHora });

            entity.ToTable("ACCESLOG");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AlFecha)
                .HasColumnType("datetime")
                .HasColumnName("AL_FECHA");
            entity.Property(e => e.AlHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_HORA");
            entity.Property(e => e.AeCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AE_CODIGO");
            entity.Property(e => e.AlCaseta)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_CASETA");
            entity.Property(e => e.AlComent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AL_COMENT");
            entity.Property(e => e.AlEntrada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_ENTRADA");
            entity.Property(e => e.AlOkFec)
                .HasColumnType("datetime")
                .HasColumnName("AL_OK_FEC");
            entity.Property(e => e.AlOkHor)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_OK_HOR");
            entity.Property(e => e.AlOkMan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_OK_MAN");
            entity.Property(e => e.AlOkSist)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_OK_SIST");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Acceslogs)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_ACCESLOG_COLABORA");
        });

        modelBuilder.Entity<Accident>(entity =>
        {
            entity.HasKey(e => new { e.ExCodigo, e.AxFecha });

            entity.ToTable("ACCIDENT");

            entity.Property(e => e.ExCodigo).HasColumnName("EX_CODIGO");
            entity.Property(e => e.AxFecha)
                .HasColumnType("datetime")
                .HasColumnName("AX_FECHA");
            entity.Property(e => e.AxAtendio).HasColumnName("AX_ATENDIO");
            entity.Property(e => e.AxCausa)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_CAUSA");
            entity.Property(e => e.AxDanMat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_DAN_MAT");
            entity.Property(e => e.AxDescrip)
                .HasColumnType("text")
                .HasColumnName("AX_DESCRIP");
            entity.Property(e => e.AxFecCom)
                .HasColumnType("datetime")
                .HasColumnName("AX_FEC_COM");
            entity.Property(e => e.AxFecReg)
                .HasColumnType("datetime")
                .HasColumnName("AX_FEC_REG");
            entity.Property(e => e.AxFecSus)
                .HasColumnType("datetime")
                .HasColumnName("AX_FEC_SUS");
            entity.Property(e => e.AxHorCom)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_HOR_COM");
            entity.Property(e => e.AxHorSus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_HOR_SUS");
            entity.Property(e => e.AxHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_HORA");
            entity.Property(e => e.AxIncapa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_INCAPA");
            entity.Property(e => e.AxInfAcc)
                .HasColumnType("text")
                .HasColumnName("AX_INF_ACC");
            entity.Property(e => e.AxInfSup)
                .HasColumnType("text")
                .HasColumnName("AX_INF_SUP");
            entity.Property(e => e.AxInfTes)
                .HasColumnType("text")
                .HasColumnName("AX_INF_TES");
            entity.Property(e => e.AxMotivo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_MOTIVO");
            entity.Property(e => e.AxNumInc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AX_NUM_INC");
            entity.Property(e => e.AxNumTes).HasColumnName("AX_NUM_TES");
            entity.Property(e => e.AxNumero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AX_NUMERO");
            entity.Property(e => e.AxObserva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AX_OBSERVA");
            entity.Property(e => e.AxPerReg)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AX_PER_REG");
            entity.Property(e => e.AxRiesgo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_RIESGO");
            entity.Property(e => e.AxTipAcc)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_TIP_ACC");
            entity.Property(e => e.AxTipLes).HasColumnName("AX_TIP_LES");
            entity.Property(e => e.AxTipo).HasColumnName("AX_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.ExCodigoNavigation).WithMany(p => p.Accidents)
                .HasForeignKey(d => d.ExCodigo)
                .HasConstraintName("FK_ACCIDENT_EXPEDIEN");
        });

        modelBuilder.Entity<Accion>(entity =>
        {
            entity.HasKey(e => e.AnCodigo);

            entity.ToTable("ACCION");

            entity.Property(e => e.AnCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AN_CODIGO");
            entity.Property(e => e.AnClase).HasColumnName("AN_CLASE");
            entity.Property(e => e.AnDetalle)
                .HasColumnType("text")
                .HasColumnName("AN_DETALLE");
            entity.Property(e => e.AnDias).HasColumnName("AN_DIAS");
            entity.Property(e => e.AnIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AN_INGLES");
            entity.Property(e => e.AnNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AN_NOMBRE");
            entity.Property(e => e.AnNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AN_NUMERO");
            entity.Property(e => e.AnTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AN_TEXTO");
            entity.Property(e => e.AnTipMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AN_TIP_MAT");
            entity.Property(e => e.AnUrl)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("AN_URL");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CuCodigoNavigation).WithMany(p => p.Accions)
                .HasForeignKey(d => d.CuCodigo)
                .HasConstraintName("FK_ACCION_CURSO");
        });

        modelBuilder.Entity<Accregla>(entity =>
        {
            entity.HasKey(e => e.AeCodigo);

            entity.ToTable("ACCREGLA", tb => tb.HasTrigger("TU_ACCREGLA"));

            entity.Property(e => e.AeCodigo)
                .ValueGeneratedNever()
                .HasColumnName("AE_CODIGO");
            entity.Property(e => e.AeActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AE_ACTIVO");
            entity.Property(e => e.AeFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AE_FILTRO");
            entity.Property(e => e.AeFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AE_FORMULA");
            entity.Property(e => e.AeLetrero)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AE_LETRERO");
            entity.Property(e => e.AeSeveri).HasColumnName("AE_SEVERI");
            entity.Property(e => e.AeTipo).HasColumnName("AE_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.QuCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CODIGO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Acumula>(entity =>
        {
            entity.HasKey(e => new { e.AcYear, e.CbCodigo, e.CoNumero });

            entity.ToTable("ACUMULA");

            entity.Property(e => e.AcYear).HasColumnName("AC_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.AcAnual)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_ANUAL");
            entity.Property(e => e.AcMes01)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_01");
            entity.Property(e => e.AcMes02)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_02");
            entity.Property(e => e.AcMes03)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_03");
            entity.Property(e => e.AcMes04)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_04");
            entity.Property(e => e.AcMes05)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_05");
            entity.Property(e => e.AcMes06)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_06");
            entity.Property(e => e.AcMes07)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_07");
            entity.Property(e => e.AcMes08)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_08");
            entity.Property(e => e.AcMes09)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_09");
            entity.Property(e => e.AcMes10)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_10");
            entity.Property(e => e.AcMes11)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_11");
            entity.Property(e => e.AcMes12)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_12");
            entity.Property(e => e.AcMes13)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MES_13");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Acumulas)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Acumula_Colabora");

            entity.HasOne(d => d.CoNumeroNavigation).WithMany(p => p.Acumulas)
                .HasForeignKey(d => d.CoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Acumula_Concepto");
        });

        modelBuilder.Entity<Aguinal>(entity =>
        {
            entity.HasKey(e => new { e.AgYear, e.CbCodigo });

            entity.ToTable("AGUINAL");

            entity.Property(e => e.AgYear).HasColumnName("AG_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AgAguinal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AG_AGUINAL");
            entity.Property(e => e.AgBase).HasColumnName("AG_BASE");
            entity.Property(e => e.AgDiasAg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AG_DIAS_AG");
            entity.Property(e => e.AgFaltas).HasColumnName("AG_FALTAS");
            entity.Property(e => e.AgFecIng)
                .HasColumnType("datetime")
                .HasColumnName("AG_FEC_ING");
            entity.Property(e => e.AgIncapa).HasColumnName("AG_INCAPA");
            entity.Property(e => e.AgNetos).HasColumnName("AG_NETOS");
            entity.Property(e => e.AgSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AG_SALARIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Aguinals)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Aguinal_Colabora");
        });

        modelBuilder.Entity<AhoPre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AHO_PRE");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.PrFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PR_FORMULA");
            entity.Property(e => e.PrMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_MONTO");
            entity.Property(e => e.PrReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PR_REFEREN");
            entity.Property(e => e.PrSaldo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_SALDO");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");
            entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");
            entity.Property(e => e.Tipo).HasColumnName("TIPO");
        });

        modelBuilder.Entity<Ahorro>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AhTipo });

            entity.ToTable("AHORRO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AhTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AH_TIPO");
            entity.Property(e => e.AhAbonos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AH_ABONOS");
            entity.Property(e => e.AhCargos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AH_CARGOS");
            entity.Property(e => e.AhFecha)
                .HasColumnType("datetime")
                .HasColumnName("AH_FECHA");
            entity.Property(e => e.AhFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AH_FORMULA");
            entity.Property(e => e.AhNumero).HasColumnName("AH_NUMERO");
            entity.Property(e => e.AhSaldo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AH_SALDO");
            entity.Property(e => e.AhSaldoI)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AH_SALDO_I");
            entity.Property(e => e.AhStatus).HasColumnName("AH_STATUS");
            entity.Property(e => e.AhSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AH_SUB_CTA");
            entity.Property(e => e.AhTotal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AH_TOTAL");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.AhTipoNavigation).WithMany(p => p.Ahorros)
                .HasForeignKey(d => d.AhTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ahorro_TAhorro");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Ahorros)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Ahorro_Colabora");
        });

        modelBuilder.Entity<Altabaja>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ALTABAJA");

            entity.Property(e => e.CbAlta)
                .HasColumnType("datetime")
                .HasColumnName("CB_ALTA");
            entity.Property(e => e.CbBaja)
                .HasColumnType("datetime")
                .HasColumnName("CB_BAJA");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PATRON");
        });

        modelBuilder.Entity<Antescur>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.ArFolio });

            entity.ToTable("ANTESCUR");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ArFolio).HasColumnName("AR_FOLIO");
            entity.Property(e => e.ArCurso)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AR_CURSO");
            entity.Property(e => e.ArFecha)
                .HasColumnType("datetime")
                .HasColumnName("AR_FECHA");
            entity.Property(e => e.ArLugar)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AR_LUGAR");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Antescurs)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_AntesCur_Colabora");
        });

        modelBuilder.Entity<Antespto>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.ApFolio });

            entity.ToTable("ANTESPTO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ApFolio).HasColumnName("AP_FOLIO");
            entity.Property(e => e.ApEmpresa)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AP_EMPRESA");
            entity.Property(e => e.ApFecFin)
                .HasColumnType("datetime")
                .HasColumnName("AP_FEC_FIN");
            entity.Property(e => e.ApFecIni)
                .HasColumnType("datetime")
                .HasColumnName("AP_FEC_INI");
            entity.Property(e => e.ApPuesto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AP_PUESTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Antesptos)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_AntesPto_Colabora");
        });

        modelBuilder.Entity<ArTemCur>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("AR_TEM_CUR");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("AREA", tb => tb.HasTrigger("TU_AREA"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.ArPriHor)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AR_PRI_HOR");
            entity.Property(e => e.ArShift).HasColumnName("AR_SHIFT");
            entity.Property(e => e.ArTipo).HasColumnName("AR_TIPO");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbBreak1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_1");
            entity.Property(e => e.TbBreak2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_2");
            entity.Property(e => e.TbBreak3)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_3");
            entity.Property(e => e.TbBreak4)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_4");
            entity.Property(e => e.TbBreak5)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_5");
            entity.Property(e => e.TbBreak6)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_6");
            entity.Property(e => e.TbBreak7)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_BREAK_7");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbOpUni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_OP_UNI");
            entity.Property(e => e.TbOpera)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TB_OPERA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Art80>(entity =>
        {
            entity.HasKey(e => new { e.NuCodigo, e.TiInicio, e.A80Li });

            entity.ToTable("ART_80");

            entity.Property(e => e.NuCodigo).HasColumnName("NU_CODIGO");
            entity.Property(e => e.TiInicio)
                .HasColumnType("datetime")
                .HasColumnName("TI_INICIO");
            entity.Property(e => e.A80Li)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("A80_LI");
            entity.Property(e => e.A80Cuota)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("A80_CUOTA");
            entity.Property(e => e.A80Tasa)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("A80_TASA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.TArt80).WithMany(p => p.Art80s)
                .HasForeignKey(d => new { d.NuCodigo, d.TiInicio })
                .HasConstraintName("FK_ART_80_T_ART_80");
        });

        modelBuilder.Entity<AsientoContable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ASIENTO_CONTABLE");

            entity.Property(e => e.Abono)
                .HasMaxLength(50)
                .HasColumnName("abono");
            entity.Property(e => e.Cargo)
                .HasMaxLength(50)
                .HasColumnName("cargo");
            entity.Property(e => e.Concepto).HasColumnName("concepto");
        });

        modelBuilder.Entity<Asigna>(entity =>
        {
            entity.HasKey(e => new { e.AsFecha, e.CbCodigo });

            entity.ToTable("ASIGNA");

            entity.HasIndex(e => new { e.AsFecha, e.CbNivel }, "XIE1ASIGNA");

            entity.Property(e => e.AsFecha)
                .HasColumnType("datetime")
                .HasColumnName("AS_FECHA");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbNivel)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Asignas)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Asigna_Colabora");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.AlCodigo);

            entity.ToTable("AULA", tb => tb.HasTrigger("TU_AULA"));

            entity.Property(e => e.AlCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_CODIGO");
            entity.Property(e => e.AlActiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_ACTIVA");
            entity.Property(e => e.AlCupo).HasColumnName("AL_CUPO");
            entity.Property(e => e.AlDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AL_DESCRIP");
            entity.Property(e => e.AlIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AL_INGLES");
            entity.Property(e => e.AlNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AL_NOMBRE");
            entity.Property(e => e.AlNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AL_NUMERO");
            entity.Property(e => e.AlTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AL_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Ausencium>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AuFecha }).IsClustered(false);

            entity.ToTable("AUSENCIA");

            entity.HasIndex(e => new { e.AuFecha, e.CbCodigo }, "XIE1AUSENCIA");

            entity.HasIndex(e => new { e.CbCodigo, e.PeYear, e.PeTipo, e.PeNumero, e.AuPosicio }, "XIE2AUSENCIA");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AuFecha)
                .HasColumnType("datetime")
                .HasColumnName("AU_FECHA");
            entity.Property(e => e.AuAutExt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_AUT_EXT");
            entity.Property(e => e.AuAutTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_AUT_TRA");
            entity.Property(e => e.AuDesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_DES_TRA");
            entity.Property(e => e.AuDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_DOBLES");
            entity.Property(e => e.AuExtras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_EXTRAS");
            entity.Property(e => e.AuHorMan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AU_HOR_MAN");
            entity.Property(e => e.AuHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_HORAS");
            entity.Property(e => e.AuHorasck)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_HORASCK");
            entity.Property(e => e.AuHorasnt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_HORASNT");
            entity.Property(e => e.AuNumExt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_NUM_EXT");
            entity.Property(e => e.AuOut2eat).HasColumnName("AU_OUT2EAT");
            entity.Property(e => e.AuPerCg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_PER_CG");
            entity.Property(e => e.AuPerSg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_PER_SG");
            entity.Property(e => e.AuPosicio).HasColumnName("AU_POSICIO");
            entity.Property(e => e.AuPreExt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_PRE_EXT");
            entity.Property(e => e.AuStaFes).HasColumnName("AU_STA_FES");
            entity.Property(e => e.AuStatus).HasColumnName("AU_STATUS");
            entity.Property(e => e.AuTardes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_TARDES");
            entity.Property(e => e.AuTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AU_TIPO");
            entity.Property(e => e.AuTipodia).HasColumnName("AU_TIPODIA");
            entity.Property(e => e.AuTriples)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AU_TRIPLES");
            entity.Property(e => e.CbClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLASIFI");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.CbNomina).HasColumnName("CB_NOMINA");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.HoCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Ausencia)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Ausencia_Colabora");
        });

        modelBuilder.Entity<Bitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BITACORA");

            entity.HasIndex(e => e.BiNumero, "XIE1BITACORA");

            entity.HasIndex(e => new { e.BiFecha, e.BiHora }, "XIE2BITACORA");

            entity.Property(e => e.BiClase).HasColumnName("BI_CLASE");
            entity.Property(e => e.BiData)
                .HasColumnType("text")
                .HasColumnName("BI_DATA");
            entity.Property(e => e.BiFecMov)
                .HasColumnType("datetime")
                .HasColumnName("BI_FEC_MOV");
            entity.Property(e => e.BiFecha)
                .HasColumnType("datetime")
                .HasColumnName("BI_FECHA");
            entity.Property(e => e.BiHora)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("BI_HORA");
            entity.Property(e => e.BiNumero).HasColumnName("BI_NUMERO");
            entity.Property(e => e.BiProcId).HasColumnName("BI_PROC_ID");
            entity.Property(e => e.BiTexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BI_TEXTO");
            entity.Property(e => e.BiTipo).HasColumnName("BI_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Break>(entity =>
        {
            entity.HasKey(e => e.BrCodigo);

            entity.ToTable("BREAKS");

            entity.Property(e => e.BrCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BR_CODIGO");
            entity.Property(e => e.BrIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BR_INGLES");
            entity.Property(e => e.BrNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BR_NOMBRE");
            entity.Property(e => e.BrNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("BR_NUMERO");
            entity.Property(e => e.BrTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BR_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<BrkHora>(entity =>
        {
            entity.HasKey(e => new { e.BrCodigo, e.BhInicio });

            entity.ToTable("BRK_HORA");

            entity.Property(e => e.BrCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BR_CODIGO");
            entity.Property(e => e.BhInicio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BH_INICIO");
            entity.Property(e => e.BhMotivo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BH_MOTIVO");
            entity.Property(e => e.BhTiempo).HasColumnName("BH_TIEMPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.BrCodigoNavigation).WithMany(p => p.BrkHoras)
                .HasForeignKey(d => d.BrCodigo)
                .HasConstraintName("FK_Brk_Hora_Breaks");
        });

        modelBuilder.Entity<CafCome>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.CfFecha, e.CfHora, e.CfTipo });

            entity.ToTable("CAF_COME");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CfFecha)
                .HasColumnType("datetime")
                .HasColumnName("CF_FECHA");
            entity.Property(e => e.CfHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF_HORA");
            entity.Property(e => e.CfTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF_TIPO");
            entity.Property(e => e.CfComidas).HasColumnName("CF_COMIDAS");
            entity.Property(e => e.CfExtras).HasColumnName("CF_EXTRAS");
            entity.Property(e => e.CfRegExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF_REG_EXT");
            entity.Property(e => e.CfReloj)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CF_RELOJ");
            entity.Property(e => e.ClCodigo).HasColumnName("CL_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.CafComes)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Caf_Come_Colabora");
        });

        modelBuilder.Entity<CafInv>(entity =>
        {
            entity.HasKey(e => new { e.IvCodigo, e.CfFecha, e.CfHora, e.CfTipo });

            entity.ToTable("CAF_INV");

            entity.Property(e => e.IvCodigo).HasColumnName("IV_CODIGO");
            entity.Property(e => e.CfFecha)
                .HasColumnType("datetime")
                .HasColumnName("CF_FECHA");
            entity.Property(e => e.CfHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF_HORA");
            entity.Property(e => e.CfTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF_TIPO");
            entity.Property(e => e.CfComidas).HasColumnName("CF_COMIDAS");
            entity.Property(e => e.CfExtras).HasColumnName("CF_EXTRAS");
            entity.Property(e => e.CfRegExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF_REG_EXT");
            entity.Property(e => e.CfReloj)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CF_RELOJ");
            entity.Property(e => e.ClCodigo).HasColumnName("CL_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.IvCodigoNavigation).WithMany(p => p.CafInvs)
                .HasForeignKey(d => d.IvCodigo)
                .HasConstraintName("FK_Caf_Inv_Invita");
        });

        modelBuilder.Entity<Cafregla>(entity =>
        {
            entity.HasKey(e => e.ClCodigo);

            entity.ToTable("CAFREGLA");

            entity.Property(e => e.ClCodigo)
                .ValueGeneratedNever()
                .HasColumnName("CL_CODIGO");
            entity.Property(e => e.ClActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CL_ACTIVO");
            entity.Property(e => e.ClExtras)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CL_EXTRAS");
            entity.Property(e => e.ClFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CL_FILTRO");
            entity.Property(e => e.ClLetrero)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CL_LETRERO");
            entity.Property(e => e.ClLimite).HasColumnName("CL_LIMITE");
            entity.Property(e => e.ClQuery)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CL_QUERY");
            entity.Property(e => e.ClTipos)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CL_TIPOS");
            entity.Property(e => e.ClTotal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CL_TOTAL");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Calcurso>(entity =>
        {
            entity.HasKey(e => new { e.CuCodigo, e.CcFecha });

            entity.ToTable("CALCURSO");

            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.CcFecha)
                .HasColumnType("datetime")
                .HasColumnName("CC_FECHA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CuCodigoNavigation).WithMany(p => p.Calcursos)
                .HasForeignKey(d => d.CuCodigo)
                .HasConstraintName("FK_CalCurso_Curso");
        });

        modelBuilder.Entity<Califica>(entity =>
        {
            entity.HasKey(e => e.CaCodigo);

            entity.ToTable("CALIFICA");

            entity.Property(e => e.CaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CA_CODIGO");
            entity.Property(e => e.CaDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CA_DESCRIP");
            entity.Property(e => e.CaGrupo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CA_GRUPO");
            entity.Property(e => e.CaIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CA_INGLES");
            entity.Property(e => e.CaNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CA_NUMERO");
            entity.Property(e => e.CaOrden).HasColumnName("CA_ORDEN");
            entity.Property(e => e.CaTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CA_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<CampoAd>(entity =>
        {
            entity.HasKey(e => e.CxNombre);

            entity.ToTable("CAMPO_AD");

            entity.Property(e => e.CxNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CX_NOMBRE");
            entity.Property(e => e.CxDefault)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CX_DEFAULT");
            entity.Property(e => e.CxEntidad).HasColumnName("CX_ENTIDAD");
            entity.Property(e => e.CxMostrar).HasColumnName("CX_MOSTRAR");
            entity.Property(e => e.CxObliga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CX_OBLIGA");
            entity.Property(e => e.CxPosicio).HasColumnName("CX_POSICIO");
            entity.Property(e => e.CxTipo).HasColumnName("CX_TIPO");
            entity.Property(e => e.CxTitulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CX_TITULO");
            entity.Property(e => e.GxCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GX_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<CampoEx>(entity =>
        {
            entity.HasKey(e => e.CxNombre);

            entity.ToTable("CAMPO_EX");

            entity.Property(e => e.CxNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CX_NOMBRE");
            entity.Property(e => e.CxDefault)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CX_DEFAULT");
            entity.Property(e => e.CxMostrar).HasColumnName("CX_MOSTRAR");
            entity.Property(e => e.CxPosicio).HasColumnName("CX_POSICIO");
            entity.Property(e => e.CxTipo).HasColumnName("CX_TIPO");
            entity.Property(e => e.CxTitulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CX_TITULO");
            entity.Property(e => e.GxCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GX_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Camporep>(entity =>
        {
            entity.HasKey(e => new { e.ReCodigo, e.CrTipo, e.CrPosicio, e.CrSubpos });

            entity.ToTable("CAMPOREP");

            entity.Property(e => e.ReCodigo).HasColumnName("RE_CODIGO");
            entity.Property(e => e.CrTipo).HasColumnName("CR_TIPO");
            entity.Property(e => e.CrPosicio).HasColumnName("CR_POSICIO");
            entity.Property(e => e.CrSubpos).HasColumnName("CR_SUBPOS");
            entity.Property(e => e.CrAlinea).HasColumnName("CR_ALINEA");
            entity.Property(e => e.CrAncho).HasColumnName("CR_ANCHO");
            entity.Property(e => e.CrBold)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CR_BOLD");
            entity.Property(e => e.CrCalc).HasColumnName("CR_CALC");
            entity.Property(e => e.CrClasifi).HasColumnName("CR_CLASIFI");
            entity.Property(e => e.CrColor).HasColumnName("CR_COLOR");
            entity.Property(e => e.CrDescrip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CR_DESCRIP");
            entity.Property(e => e.CrFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CR_FORMULA");
            entity.Property(e => e.CrItalic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CR_ITALIC");
            entity.Property(e => e.CrMascara)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CR_MASCARA");
            entity.Property(e => e.CrOper).HasColumnName("CR_OPER");
            entity.Property(e => e.CrRequier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CR_REQUIER");
            entity.Property(e => e.CrShow).HasColumnName("CR_SHOW");
            entity.Property(e => e.CrStrike)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CR_STRIKE");
            entity.Property(e => e.CrSubraya)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CR_SUBRAYA");
            entity.Property(e => e.CrTabla).HasColumnName("CR_TABLA");
            entity.Property(e => e.CrTfield).HasColumnName("CR_TFIELD");
            entity.Property(e => e.CrTitulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CR_TITULO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.ReCodigoNavigation).WithMany(p => p.Camporeps)
                .HasForeignKey(d => d.ReCodigo)
                .HasConstraintName("FK_CampoRep_Reporte");
        });

        modelBuilder.Entity<Causacci>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("CAUSACCI", tb => tb.HasTrigger("TU_CAUSACCI"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Ccurso>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("CCURSO", tb => tb.HasTrigger("TU_CCURSO"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<CedEmp>(entity =>
        {
            entity.HasKey(e => new { e.CeFolio, e.CbCodigo });

            entity.ToTable("CED_EMP");

            entity.Property(e => e.CeFolio).HasColumnName("CE_FOLIO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CePosicio).HasColumnName("CE_POSICIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CeFolioNavigation).WithMany(p => p.CedEmps)
                .HasForeignKey(d => d.CeFolio)
                .HasConstraintName("FK_Ced_Emp_Cedula");
        });

        modelBuilder.Entity<CedInsp>(entity =>
        {
            entity.HasKey(e => e.CiFolio);

            entity.ToTable("CED_INSP");

            entity.Property(e => e.CiFolio)
                .ValueGeneratedNever()
                .HasColumnName("CI_FOLIO");
            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CeFolio).HasColumnName("CE_FOLIO");
            entity.Property(e => e.CiArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_AREA");
            entity.Property(e => e.CiComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CI_COMENTA");
            entity.Property(e => e.CiFecha)
                .HasColumnType("datetime")
                .HasColumnName("CI_FECHA");
            entity.Property(e => e.CiHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_HORA");
            entity.Property(e => e.CiMuestra)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CI_MUESTRA");
            entity.Property(e => e.CiNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CI_NUMERO1");
            entity.Property(e => e.CiNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CI_NUMERO2");
            entity.Property(e => e.CiObserva)
                .HasColumnType("text")
                .HasColumnName("CI_OBSERVA");
            entity.Property(e => e.CiResult).HasColumnName("CI_RESULT");
            entity.Property(e => e.CiTamlote)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CI_TAMLOTE");
            entity.Property(e => e.CiTiempo).HasColumnName("CI_TIEMPO");
            entity.Property(e => e.CiTipo).HasColumnName("CI_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        modelBuilder.Entity<CedWord>(entity =>
        {
            entity.HasKey(e => new { e.CeFolio, e.WoNumber });

            entity.ToTable("CED_WORD");

            entity.Property(e => e.CeFolio).HasColumnName("CE_FOLIO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
            entity.Property(e => e.CwPiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CW_PIEZAS");
            entity.Property(e => e.CwPosicio).HasColumnName("CW_POSICIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CeFolioNavigation).WithMany(p => p.CedWords)
                .HasForeignKey(d => d.CeFolio)
                .HasConstraintName("FK_Ced_Word_Cedula");
        });

        modelBuilder.Entity<Cedscrap>(entity =>
        {
            entity.HasKey(e => e.CsFolio);

            entity.ToTable("CEDSCRAP");

            entity.Property(e => e.CsFolio)
                .ValueGeneratedNever()
                .HasColumnName("CS_FOLIO");
            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CsArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CS_AREA");
            entity.Property(e => e.CsComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CS_COMENTA");
            entity.Property(e => e.CsFecFab)
                .HasColumnType("datetime")
                .HasColumnName("CS_FEC_FAB");
            entity.Property(e => e.CsFecha)
                .HasColumnType("datetime")
                .HasColumnName("CS_FECHA");
            entity.Property(e => e.CsHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CS_HORA");
            entity.Property(e => e.CsNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_NUMERO1");
            entity.Property(e => e.CsNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_NUMERO2");
            entity.Property(e => e.CsObserva)
                .HasColumnType("text")
                .HasColumnName("CS_OBSERVA");
            entity.Property(e => e.CsTamlote)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CS_TAMLOTE");
            entity.Property(e => e.CsTexto1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CS_TEXTO1");
            entity.Property(e => e.CsTexto2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CS_TEXTO2");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        modelBuilder.Entity<Cedula>(entity =>
        {
            entity.HasKey(e => e.CeFolio);

            entity.ToTable("CEDULA");

            entity.HasIndex(e => new { e.CeArea, e.CeFecha, e.CeHora }, "XAK1CEDULA").IsUnique();

            entity.Property(e => e.CeFolio)
                .ValueGeneratedNever()
                .HasColumnName("CE_FOLIO");
            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CeArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_AREA");
            entity.Property(e => e.CeComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CE_COMENTA");
            entity.Property(e => e.CeFecha)
                .HasColumnType("datetime")
                .HasColumnName("CE_FECHA");
            entity.Property(e => e.CeHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_HORA");
            entity.Property(e => e.CeMod1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MOD_1");
            entity.Property(e => e.CeMod2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MOD_2");
            entity.Property(e => e.CeMod3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MOD_3");
            entity.Property(e => e.CeMulti)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MULTI");
            entity.Property(e => e.CePiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CE_PIEZAS");
            entity.Property(e => e.CeStatus).HasColumnName("CE_STATUS");
            entity.Property(e => e.CeTiempo)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CE_TIEMPO");
            entity.Property(e => e.CeTipo).HasColumnName("CE_TIPO");
            entity.Property(e => e.CeTmuerto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_TMUERTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        modelBuilder.Entity<CerProg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CER_PROG");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CiCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_CODIGO");
            entity.Property(e => e.KiCalif1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KI_CALIF_1");
            entity.Property(e => e.KiCalif2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KI_CALIF_2");
            entity.Property(e => e.KiCalif3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KI_CALIF_3");
            entity.Property(e => e.KiFecPro)
                .HasColumnType("datetime")
                .HasColumnName("KI_FEC_PRO");
            entity.Property(e => e.KiFecTom)
                .HasColumnType("datetime")
                .HasColumnName("KI_FEC_TOM");
            entity.Property(e => e.PcLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_LISTA");
            entity.Property(e => e.PcOpciona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_OPCIONA");
        });

        modelBuilder.Entity<Cernivel>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.CiCodigo, e.CnCodigo });

            entity.ToTable("CERNIVEL");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.CiCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_CODIGO");
            entity.Property(e => e.CnCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.PtoCert).WithMany(p => p.Cernivels)
                .HasForeignKey(d => new { d.CiCodigo, d.PuCodigo })
                .HasConstraintName("FK_CERNIVEL");
        });

        modelBuilder.Entity<Certific>(entity =>
        {
            entity.HasKey(e => e.CiCodigo);

            entity.ToTable("CERTIFIC");

            entity.Property(e => e.CiCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_CODIGO");
            entity.Property(e => e.CiActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_ACTIVO");
            entity.Property(e => e.CiDetalle)
                .HasColumnType("text")
                .HasColumnName("CI_DETALLE");
            entity.Property(e => e.CiIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CI_INGLES");
            entity.Property(e => e.CiNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CI_NOMBRE");
            entity.Property(e => e.CiNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CI_NUMERO");
            entity.Property(e => e.CiRenovar).HasColumnName("CI_RENOVAR");
            entity.Property(e => e.CiResumen)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CI_RESUMEN");
            entity.Property(e => e.CiTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CI_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Checada>(entity =>
        {
            entity.HasKey(e => new { e.AuFecha, e.CbCodigo, e.ChHReal, e.ChTipo });

            entity.ToTable("CHECADAS");

            entity.Property(e => e.AuFecha)
                .HasColumnType("datetime")
                .HasColumnName("AU_FECHA");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ChHReal)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CH_H_REAL");
            entity.Property(e => e.ChTipo).HasColumnName("CH_TIPO");
            entity.Property(e => e.ChDescrip).HasColumnName("CH_DESCRIP");
            entity.Property(e => e.ChGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CH_GLOBAL");
            entity.Property(e => e.ChHAjus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CH_H_AJUS");
            entity.Property(e => e.ChHorDes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CH_HOR_DES");
            entity.Property(e => e.ChHorExt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CH_HOR_EXT");
            entity.Property(e => e.ChHorOrd)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CH_HOR_ORD");
            entity.Property(e => e.ChIgnorar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CH_IGNORAR");
            entity.Property(e => e.ChMotivo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CH_MOTIVO");
            entity.Property(e => e.ChPosicio).HasColumnName("CH_POSICIO");
            entity.Property(e => e.ChReloj)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CH_RELOJ");
            entity.Property(e => e.ChSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CH_SISTEMA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodOk).HasColumnName("US_COD_OK");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.Ausencium).WithMany(p => p.Checada)
                .HasForeignKey(d => new { d.CbCodigo, d.AuFecha })
                .HasConstraintName("FK_Checadas_Ausencia");
        });

        modelBuilder.Entity<Clasifi>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("CLASIFI", tb => tb.HasTrigger("TU_CLASIFI"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbOp1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_OP1");
            entity.Property(e => e.TbOp2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_OP2");
            entity.Property(e => e.TbOp3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_OP3");
            entity.Property(e => e.TbOp4)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_OP4");
            entity.Property(e => e.TbOp5)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_OP5");
            entity.Property(e => e.TbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_SALARIO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Clasitmp>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AuFecha });

            entity.ToTable("CLASITMP");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AuFecha)
                .HasColumnType("datetime")
                .HasColumnName("AU_FECHA");
            entity.Property(e => e.CbClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLASIFI");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.CtFecOk)
                .HasColumnType("datetime")
                .HasColumnName("CT_FEC_OK");
            entity.Property(e => e.CtFecha)
                .HasColumnType("datetime")
                .HasColumnName("CT_FECHA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodOk).HasColumnName("US_COD_OK");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Clasitmps)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_CLASITMP_COLABORA");
        });

        modelBuilder.Entity<Colabora>(entity =>
        {
            entity.HasKey(e => e.CbCodigo);

            entity.ToTable("COLABORA", tb =>
                {
                    tb.HasTrigger("TD_COLABORA");
                    tb.HasTrigger("TU_COLABORA");
                });

            entity.HasIndex(e => e.CbPuesto, "XIE1COLABORA");

            entity.HasIndex(e => e.CbIdNum, "XIE2COLABORA");

            entity.Property(e => e.CbCodigo)
                .ValueGeneratedNever()
                .HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ACTIVO");
            entity.Property(e => e.CbApeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_APE_MAT");
            entity.Property(e => e.CbApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_APE_PAT");
            entity.Property(e => e.CbArFec)
                .HasColumnType("datetime")
                .HasColumnName("CB_AR_FEC");
            entity.Property(e => e.CbArHor)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AR_HOR");
            entity.Property(e => e.CbArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AREA");
            entity.Property(e => e.CbAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AUTOSAL");
            entity.Property(e => e.CbBanEle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_BAN_ELE");
            entity.Property(e => e.CbCalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CB_CALLE");
            entity.Property(e => e.CbCandida).HasColumnName("CB_CANDIDA");
            entity.Property(e => e.CbCarrera)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CB_CARRERA");
            entity.Property(e => e.CbCheca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CHECA");
            entity.Property(e => e.CbCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CIUDAD");
            entity.Property(e => e.CbClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLASIFI");
            entity.Property(e => e.CbClinica)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLINICA");
            entity.Property(e => e.CbCodCol)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_COD_COL");
            entity.Property(e => e.CbCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CB_CODPOST");
            entity.Property(e => e.CbColonia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_COLONIA");
            entity.Property(e => e.CbContrat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CONTRAT");
            entity.Property(e => e.CbCredenc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CREDENC");
            entity.Property(e => e.CbCtaGas)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CTA_GAS");
            entity.Property(e => e.CbCtaVal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CTA_VAL");
            entity.Property(e => e.CbCurp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CURP");
            entity.Property(e => e.CbDerFec)
                .HasColumnType("datetime")
                .HasColumnName("CB_DER_FEC");
            entity.Property(e => e.CbDerGoz)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_DER_GOZ");
            entity.Property(e => e.CbDerPag)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_DER_PAG");
            entity.Property(e => e.CbDerPv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_DER_PV");
            entity.Property(e => e.CbDiscapa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_DISCAPA");
            entity.Property(e => e.CbDnnOk)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_DNN_OK");
            entity.Property(e => e.CbEMail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CB_E_MAIL");
            entity.Property(e => e.CbEdoCiv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_EDO_CIV");
            entity.Property(e => e.CbEmpleo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_EMPLEO");
            entity.Property(e => e.CbEntNac)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ENT_NAC");
            entity.Property(e => e.CbEscuela)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CB_ESCUELA");
            entity.Property(e => e.CbEstHor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_EST_HOR");
            entity.Property(e => e.CbEstHoy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_EST_HOY");
            entity.Property(e => e.CbEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ESTADO");
            entity.Property(e => e.CbEstudio)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ESTUDIO");
            entity.Property(e => e.CbEvalua)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_EVALUA");
            entity.Property(e => e.CbExperie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CB_EXPERIE");
            entity.Property(e => e.CbFacInt)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("CB_FAC_INT");
            entity.Property(e => e.CbFecAnt)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ANT");
            entity.Property(e => e.CbFecBaj)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_BAJ");
            entity.Property(e => e.CbFecBss)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_BSS");
            entity.Property(e => e.CbFecCon)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_CON");
            entity.Property(e => e.CbFecCov)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_COV");
            entity.Property(e => e.CbFecInc)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_INC");
            entity.Property(e => e.CbFecIng)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ING");
            entity.Property(e => e.CbFecInt)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_INT");
            entity.Property(e => e.CbFecKar)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_KAR");
            entity.Property(e => e.CbFecNac)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_NAC");
            entity.Property(e => e.CbFecNiv)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_NIV");
            entity.Property(e => e.CbFecNom)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_NOM");
            entity.Property(e => e.CbFecPer)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_PER");
            entity.Property(e => e.CbFecPla)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_PLA");
            entity.Property(e => e.CbFecPto)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_PTO");
            entity.Property(e => e.CbFecRes)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_RES");
            entity.Property(e => e.CbFecRev)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_REV");
            entity.Property(e => e.CbFecSal)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_SAL");
            entity.Property(e => e.CbFecTur)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_TUR");
            entity.Property(e => e.CbFecVac)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_VAC");
            entity.Property(e => e.CbFonacot)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_FONACOT");
            entity.Property(e => e.CbGFec1)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_1");
            entity.Property(e => e.CbGFec2)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_2");
            entity.Property(e => e.CbGFec3)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_3");
            entity.Property(e => e.CbGFec4)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_4");
            entity.Property(e => e.CbGFec5)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_5");
            entity.Property(e => e.CbGFec6)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_6");
            entity.Property(e => e.CbGFec7)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_7");
            entity.Property(e => e.CbGFec8)
                .HasColumnType("datetime")
                .HasColumnName("CB_G_FEC_8");
            entity.Property(e => e.CbGLog1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_1");
            entity.Property(e => e.CbGLog2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_2");
            entity.Property(e => e.CbGLog3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_3");
            entity.Property(e => e.CbGLog4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_4");
            entity.Property(e => e.CbGLog5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_5");
            entity.Property(e => e.CbGLog6)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_6");
            entity.Property(e => e.CbGLog7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_7");
            entity.Property(e => e.CbGLog8)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_LOG_8");
            entity.Property(e => e.CbGNum1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_1");
            entity.Property(e => e.CbGNum10)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM10");
            entity.Property(e => e.CbGNum11)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM11");
            entity.Property(e => e.CbGNum12)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM12");
            entity.Property(e => e.CbGNum13)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM13");
            entity.Property(e => e.CbGNum14)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM14");
            entity.Property(e => e.CbGNum15)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM15");
            entity.Property(e => e.CbGNum16)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM16");
            entity.Property(e => e.CbGNum17)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM17");
            entity.Property(e => e.CbGNum18)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM18");
            entity.Property(e => e.CbGNum2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_2");
            entity.Property(e => e.CbGNum3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_3");
            entity.Property(e => e.CbGNum4)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_4");
            entity.Property(e => e.CbGNum5)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_5");
            entity.Property(e => e.CbGNum6)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_6");
            entity.Property(e => e.CbGNum7)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_7");
            entity.Property(e => e.CbGNum8)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_8");
            entity.Property(e => e.CbGNum9)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_G_NUM_9");
            entity.Property(e => e.CbGTab1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_1");
            entity.Property(e => e.CbGTab10)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB10");
            entity.Property(e => e.CbGTab11)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB11");
            entity.Property(e => e.CbGTab12)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB12");
            entity.Property(e => e.CbGTab13)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB13");
            entity.Property(e => e.CbGTab14)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB14");
            entity.Property(e => e.CbGTab2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_2");
            entity.Property(e => e.CbGTab3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_3");
            entity.Property(e => e.CbGTab4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_4");
            entity.Property(e => e.CbGTab5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_5");
            entity.Property(e => e.CbGTab6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_6");
            entity.Property(e => e.CbGTab7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_7");
            entity.Property(e => e.CbGTab8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_8");
            entity.Property(e => e.CbGTab9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_G_TAB_9");
            entity.Property(e => e.CbGTex1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_1");
            entity.Property(e => e.CbGTex10)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX10");
            entity.Property(e => e.CbGTex11)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX11");
            entity.Property(e => e.CbGTex12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX12");
            entity.Property(e => e.CbGTex13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX13");
            entity.Property(e => e.CbGTex14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX14");
            entity.Property(e => e.CbGTex15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX15");
            entity.Property(e => e.CbGTex16)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX16");
            entity.Property(e => e.CbGTex17)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX17");
            entity.Property(e => e.CbGTex18)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX18");
            entity.Property(e => e.CbGTex19)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX19");
            entity.Property(e => e.CbGTex2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_2");
            entity.Property(e => e.CbGTex20)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX20");
            entity.Property(e => e.CbGTex21)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX21");
            entity.Property(e => e.CbGTex22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX22");
            entity.Property(e => e.CbGTex23)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX23");
            entity.Property(e => e.CbGTex24)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX24");
            entity.Property(e => e.CbGTex3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_3");
            entity.Property(e => e.CbGTex4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_4");
            entity.Property(e => e.CbGTex5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_5");
            entity.Property(e => e.CbGTex6)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_6");
            entity.Property(e => e.CbGTex7)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_7");
            entity.Property(e => e.CbGTex8)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_8");
            entity.Property(e => e.CbGTex9)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_G_TEX_9");
            entity.Property(e => e.CbHabla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_HABLA");
            entity.Property(e => e.CbIdNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_ID_NUM");
            entity.Property(e => e.CbIdioma)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_IDIOMA");
            entity.Property(e => e.CbIndige)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_INDIGE");
            entity.Property(e => e.CbInfAnt)
                .HasColumnType("datetime")
                .HasColumnName("CB_INF_ANT");
            entity.Property(e => e.CbInfIni)
                .HasColumnType("datetime")
                .HasColumnName("CB_INF_INI");
            entity.Property(e => e.CbInfOld)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CB_INF_OLD");
            entity.Property(e => e.CbInfact)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_INFACT");
            entity.Property(e => e.CbInfcred)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_INFCRED");
            entity.Property(e => e.CbInfdism)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_INFDISM");
            entity.Property(e => e.CbInfmant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_INFMANT");
            entity.Property(e => e.CbInftasa)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CB_INFTASA");
            entity.Property(e => e.CbInftipo).HasColumnName("CB_INFTIPO");
            entity.Property(e => e.CbLaMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_LA_MAT");
            entity.Property(e => e.CbLastEv)
                .HasColumnType("datetime")
                .HasColumnName("CB_LAST_EV");
            entity.Property(e => e.CbLugNac)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_LUG_NAC");
            entity.Property(e => e.CbMaquina)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CB_MAQUINA");
            entity.Property(e => e.CbMedTra)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MED_TRA");
            entity.Property(e => e.CbMotBaj)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOT_BAJ");
            entity.Property(e => e.CbMunicip)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MUNICIP");
            entity.Property(e => e.CbNacion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_NACION");
            entity.Property(e => e.CbNeto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_NETO");
            entity.Property(e => e.CbNextEv)
                .HasColumnType("datetime")
                .HasColumnName("CB_NEXT_EV");
            entity.Property(e => e.CbNivel0)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL0");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.CbNombres)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_NOMBRES");
            entity.Property(e => e.CbNomina).HasColumnName("CB_NOMINA");
            entity.Property(e => e.CbNomnume).HasColumnName("CB_NOMNUME");
            entity.Property(e => e.CbNomtipo).HasColumnName("CB_NOMTIPO");
            entity.Property(e => e.CbNomyear).HasColumnName("CB_NOMYEAR");
            entity.Property(e => e.CbNumExt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CB_NUM_EXT");
            entity.Property(e => e.CbNumInt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CB_NUM_INT");
            entity.Property(e => e.CbOldInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_OLD_INT");
            entity.Property(e => e.CbOldSal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_OLD_SAL");
            entity.Property(e => e.CbPasapor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PASAPOR");
            entity.Property(e => e.CbPasswrd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_PASSWRD");
            entity.Property(e => e.CbPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PATRON");
            entity.Property(e => e.CbPension).HasColumnName("CB_PENSION");
            entity.Property(e => e.CbPerVar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_PER_VAR");
            entity.Property(e => e.CbPlaza).HasColumnName("CB_PLAZA");
            entity.Property(e => e.CbPortal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PORTAL");
            entity.Property(e => e.CbPreInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_PRE_INT");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CbRangoS)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("CB_RANGO_S");
            entity.Property(e => e.CbRecontr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_RECONTR");
            entity.Property(e => e.CbRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_RFC");
            entity.Property(e => e.CbSalInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SAL_INT");
            entity.Property(e => e.CbSalTot)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SAL_TOT");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CbSegsoc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_SEGSOC");
            entity.Property(e => e.CbSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_SEXO");
            entity.Property(e => e.CbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_SUB_CTA");
            entity.Property(e => e.CbTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TABLASS");
            entity.Property(e => e.CbTdiscap).HasColumnName("CB_TDISCAP");
            entity.Property(e => e.CbTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_TEL");
            entity.Property(e => e.CbTescuel).HasColumnName("CB_TESCUEL");
            entity.Property(e => e.CbTipRev)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TIP_REV");
            entity.Property(e => e.CbTitulo).HasColumnName("CB_TITULO");
            entity.Property(e => e.CbTotGra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_TOT_GRA");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.CbUsrname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CB_USRNAME");
            entity.Property(e => e.CbVGozo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_V_GOZO");
            entity.Property(e => e.CbVPago)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_V_PAGO");
            entity.Property(e => e.CbVPrima)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_V_PRIMA");
            entity.Property(e => e.CbVivecon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_VIVECON");
            entity.Property(e => e.CbViveen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_VIVEEN");
            entity.Property(e => e.CbYtitulo).HasColumnName("CB_YTITULO");
            entity.Property(e => e.CbZona)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CB_ZONA");
            entity.Property(e => e.CbZonaGe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ZONA_GE");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.Prettyname)
                .HasMaxLength(93)
                .IsUnicode(false)
                .HasComputedColumnSql("([CB_APE_PAT] + ' ' + [CB_APE_MAT] + ', ' + [CB_NOMBRES])", false)
                .HasColumnName("PRETTYNAME");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Colonium>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("COLONIA", tb => tb.HasTrigger("TU_COLONIA"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbClinica)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CLINICA");
            entity.Property(e => e.TbCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TB_CODPOST");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbZona)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TB_ZONA");
        });

        modelBuilder.Entity<CompCal>(entity =>
        {
            entity.HasKey(e => new { e.CmCodigo, e.CaCodigo });

            entity.ToTable("COMP_CAL", tb => tb.HasTrigger("TU_COMP_CAL"));

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CA_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.McDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MC_DESCRIP");

            entity.HasOne(d => d.CaCodigoNavigation).WithMany(p => p.CompCals)
                .HasForeignKey(d => d.CaCodigo)
                .HasConstraintName("FK_COMP_CAL_CALIFICA");

            entity.HasOne(d => d.CmCodigoNavigation).WithMany(p => p.CompCals)
                .HasForeignKey(d => d.CmCodigo)
                .HasConstraintName("FK_COMP_CAL_COMPETEN");
        });

        modelBuilder.Entity<CompFam>(entity =>
        {
            entity.HasKey(e => new { e.FpCodigo, e.CmCodigo });

            entity.ToTable("COMP_FAM");

            entity.Property(e => e.FpCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FP_CODIGO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CfObserva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CF_OBSERVA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CmCodigoNavigation).WithMany(p => p.CompFams)
                .HasForeignKey(d => d.CmCodigo)
                .HasConstraintName("FK_COMP_FAM_COMPETEN");

            entity.HasOne(d => d.FpCodigoNavigation).WithMany(p => p.CompFams)
                .HasForeignKey(d => d.FpCodigo)
                .HasConstraintName("FK_COMP_FAM_FAM_PTO");
        });

        modelBuilder.Entity<CompMap>(entity =>
        {
            entity.HasKey(e => new { e.CmCodigo, e.AnCodigo });

            entity.ToTable("COMP_MAP");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.AnCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AN_CODIGO");
            entity.Property(e => e.CmObserva)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CM_OBSERVA");
            entity.Property(e => e.CmOrden).HasColumnName("CM_ORDEN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.AnCodigoNavigation).WithMany(p => p.CompMaps)
                .HasForeignKey(d => d.AnCodigo)
                .HasConstraintName("FK_COMP_MAP_ACCION");

            entity.HasOne(d => d.CmCodigoNavigation).WithMany(p => p.CompMaps)
                .HasForeignKey(d => d.CmCodigo)
                .HasConstraintName("FK_COMP_MAP_COMPETEN");
        });

        modelBuilder.Entity<CompPto>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.CmCodigo });

            entity.ToTable("COMP_PTO");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CA_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MpDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MP_DESCRIP");

            entity.HasOne(d => d.CmCodigoNavigation).WithMany(p => p.CompPtos)
                .HasForeignKey(d => d.CmCodigo)
                .HasConstraintName("FK_COMP_PTO_COMPETEN");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.CompPtos)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_COMP_PTO_PUESTO");
        });

        modelBuilder.Entity<Compara>(entity =>
        {
            entity.HasKey(e => new { e.CpYear, e.CbCodigo });

            entity.ToTable("COMPARA");

            entity.Property(e => e.CpYear).HasColumnName("CP_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CpAPagar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_A_PAGAR");
            entity.Property(e => e.CpArt141)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_ART_141");
            entity.Property(e => e.CpCalculo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CP_CALCULO");
            entity.Property(e => e.CpContra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_CONTRA");
            entity.Property(e => e.CpFavor)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_FAVOR");
            entity.Property(e => e.CpGravado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_GRAVADO");
            entity.Property(e => e.CpPagado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_PAGADO");
            entity.Property(e => e.CpRetenid)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_RETENID");
            entity.Property(e => e.CpTotPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CP_TOT_PER");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Comparas)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Compara_Colabora");
        });

        modelBuilder.Entity<Competen>(entity =>
        {
            entity.HasKey(e => e.CmCodigo);

            entity.ToTable("COMPETEN");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CmDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_DESCRIP");
            entity.Property(e => e.CmDetalle)
                .HasColumnType("text")
                .HasColumnName("CM_DETALLE");
            entity.Property(e => e.CmIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_INGLES");
            entity.Property(e => e.CmNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_NUMERO");
            entity.Property(e => e.CmTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TcCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TC_CODIGO");
        });

        modelBuilder.Entity<Componen>(entity =>
        {
            entity.HasKey(e => e.CnCodigo);

            entity.ToTable("COMPONEN");

            entity.Property(e => e.CnCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CN_CODIGO");
            entity.Property(e => e.CnBarcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CN_BARCODE");
            entity.Property(e => e.CnCosto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CN_COSTO");
            entity.Property(e => e.CnDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CN_DETALLE");
            entity.Property(e => e.CnIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CN_INGLES");
            entity.Property(e => e.CnNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CN_NOMBRE");
            entity.Property(e => e.CnNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CN_NUMERO1");
            entity.Property(e => e.CnNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CN_NUMERO2");
            entity.Property(e => e.CnShort)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CN_SHORT");
            entity.Property(e => e.CnTexto1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CN_TEXTO1");
            entity.Property(e => e.CnTexto2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CN_TEXTO2");
            entity.Property(e => e.CnUnidad)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CN_UNIDAD");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Concepto>(entity =>
        {
            entity.HasKey(e => e.CoNumero);

            entity.ToTable("CONCEPTO", tb => tb.HasTrigger("TU_CONCEPTO"));

            entity.Property(e => e.CoNumero)
                .ValueGeneratedNever()
                .HasColumnName("CO_NUMERO");
            entity.Property(e => e.CoAPtu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_A_PTU");
            entity.Property(e => e.CoActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_ACTIVO");
            entity.Property(e => e.CoCalcula)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_CALCULA");
            entity.Property(e => e.CoCambia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_CAMBIA");
            entity.Property(e => e.CoDBlob)
                .HasColumnType("image")
                .HasColumnName("CO_D_BLOB");
            entity.Property(e => e.CoDExt)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_D_EXT");
            entity.Property(e => e.CoDNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_D_NOM");
            entity.Property(e => e.CoDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_DESCRIP");
            entity.Property(e => e.CoFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_FORMULA");
            entity.Property(e => e.CoGImss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_G_IMSS");
            entity.Property(e => e.CoGIspt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_G_ISPT");
            entity.Property(e => e.CoGpoAcc)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("CO_GPO_ACC");
            entity.Property(e => e.CoImpCal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_IMP_CAL");
            entity.Property(e => e.CoImprime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_IMPRIME");
            entity.Property(e => e.CoLimInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CO_LIM_INF");
            entity.Property(e => e.CoLimSup)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CO_LIM_SUP");
            entity.Property(e => e.CoListado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_LISTADO");
            entity.Property(e => e.CoMensual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_MENSUAL");
            entity.Property(e => e.CoNota)
                .HasColumnType("text")
                .HasColumnName("CO_NOTA");
            entity.Property(e => e.CoOrden).HasColumnName("CO_ORDEN");
            entity.Property(e => e.CoQuery)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_QUERY");
            entity.Property(e => e.CoRecibo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_RECIBO");
            entity.Property(e => e.CoSql)
                .IsUnicode(false)
                .HasColumnName("CO_SQL");
            entity.Property(e => e.CoSqlImpc)
                .IsUnicode(false)
                .HasColumnName("CO_SQL_IMPC");
            entity.Property(e => e.CoSqlIspt)
                .IsUnicode(false)
                .HasColumnName("CO_SQL_ISPT");
            entity.Property(e => e.CoSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_SUB_CTA");
            entity.Property(e => e.CoTipo).HasColumnName("CO_TIPO");
            entity.Property(e => e.CoVerAcc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_VER_ACC");
            entity.Property(e => e.CoVerInf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_VER_INF");
            entity.Property(e => e.CoVerSup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_VER_SUP");
            entity.Property(e => e.CoXIspt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_X_ISPT");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<ConceptosSat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONCEPTOS_SAT");

            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.CoSat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CO_SAT");
            entity.Property(e => e.CoTipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_TIPO");
        });

        modelBuilder.Entity<Consultum>(entity =>
        {
            entity.HasKey(e => new { e.ExCodigo, e.CnFecha, e.CnTipo });

            entity.ToTable("CONSULTA");

            entity.Property(e => e.ExCodigo).HasColumnName("EX_CODIGO");
            entity.Property(e => e.CnFecha)
                .HasColumnType("datetime")
                .HasColumnName("CN_FECHA");
            entity.Property(e => e.CnTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_TIPO");
            entity.Property(e => e.CnAltura)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CN_ALTURA");
            entity.Property(e => e.CnAvDer).HasColumnName("CN_AV_DER");
            entity.Property(e => e.CnAvIzq).HasColumnName("CN_AV_IZQ");
            entity.Property(e => e.CnCuidado)
                .HasColumnType("text")
                .HasColumnName("CN_CUIDADO");
            entity.Property(e => e.CnDBlob)
                .HasColumnType("image")
                .HasColumnName("CN_D_BLOB");
            entity.Property(e => e.CnDExt)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_D_EXT");
            entity.Property(e => e.CnDObs)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CN_D_OBS");
            entity.Property(e => e.CnDiagnos)
                .HasColumnType("text")
                .HasColumnName("CN_DIAGNOS");
            entity.Property(e => e.CnEstDes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CN_EST_DES");
            entity.Property(e => e.CnEstFec)
                .HasColumnType("datetime")
                .HasColumnName("CN_EST_FEC");
            entity.Property(e => e.CnEstHay)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_EST_HAY");
            entity.Property(e => e.CnEstObs)
                .HasColumnType("text")
                .HasColumnName("CN_EST_OBS");
            entity.Property(e => e.CnEstRes)
                .HasColumnType("text")
                .HasColumnName("CN_EST_RES");
            entity.Property(e => e.CnEstTip)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_EST_TIP");
            entity.Property(e => e.CnExplora)
                .HasColumnType("text")
                .HasColumnName("CN_EXPLORA");
            entity.Property(e => e.CnFecMod)
                .HasColumnType("datetime")
                .HasColumnName("CN_FEC_MOD");
            entity.Property(e => e.CnHorFin)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_HOR_FIN");
            entity.Property(e => e.CnHorIni)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_HOR_INI");
            entity.Property(e => e.CnImss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_IMSS");
            entity.Property(e => e.CnMotivo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CN_MOTIVO");
            entity.Property(e => e.CnObserva)
                .HasColumnType("text")
                .HasColumnName("CN_OBSERVA");
            entity.Property(e => e.CnPeso)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CN_PESO");
            entity.Property(e => e.CnPreDia).HasColumnName("CN_PRE_DIA");
            entity.Property(e => e.CnPreSis).HasColumnName("CN_PRE_SIS");
            entity.Property(e => e.CnPulso).HasColumnName("CN_PULSO");
            entity.Property(e => e.CnReceta)
                .HasColumnType("text")
                .HasColumnName("CN_RECETA");
            entity.Property(e => e.CnRespira).HasColumnName("CN_RESPIRA");
            entity.Property(e => e.CnSintoma)
                .HasColumnType("text")
                .HasColumnName("CN_SINTOMA");
            entity.Property(e => e.CnSubSec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CN_SUB_SEC");
            entity.Property(e => e.CnTempera).HasColumnName("CN_TEMPERA");
            entity.Property(e => e.DaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DA_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.ExCodigoNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.ExCodigo)
                .HasConstraintName("FK_CONSULTA_EXPEDIEN");
        });

        modelBuilder.Entity<Conteo>(entity =>
        {
            entity.HasKey(e => new { e.CtFecha, e.CtNivel1, e.CtNivel2, e.CtNivel3, e.CtNivel4, e.CtNivel5 });

            entity.ToTable("CONTEO");

            entity.Property(e => e.CtFecha)
                .HasColumnType("datetime")
                .HasColumnName("CT_FECHA");
            entity.Property(e => e.CtNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_NIVEL_1");
            entity.Property(e => e.CtNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_NIVEL_2");
            entity.Property(e => e.CtNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_NIVEL_3");
            entity.Property(e => e.CtNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_NIVEL_4");
            entity.Property(e => e.CtNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_NIVEL_5");
            entity.Property(e => e.CtCuantos).HasColumnName("CT_CUANTOS");
            entity.Property(e => e.CtNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CT_NUMERO1");
            entity.Property(e => e.CtNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CT_NUMERO2");
            entity.Property(e => e.CtNumero3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CT_NUMERO3");
            entity.Property(e => e.CtReal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CT_REAL");
            entity.Property(e => e.CtTexto1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CT_TEXTO1");
            entity.Property(e => e.CtTexto2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CT_TEXTO2");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<ContraCuenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONTRA_CUENTAS");

            entity.Property(e => e.Concepto).HasColumnName("CONCEPTO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("CONTRATO", tb => tb.HasTrigger("TU_CONTRATO"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbDias).HasColumnName("TB_DIAS");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<CtaMov>(entity =>
        {
            entity.HasKey(e => e.CmFolio);

            entity.ToTable("CTA_MOVS");

            entity.HasIndex(e => new { e.CtCodigo, e.CmFecha, e.CmDepRet }, "XIE1CTA_MOVS");

            entity.Property(e => e.CmFolio).HasColumnName("CM_FOLIO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CmBenefi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CM_BENEFI");
            entity.Property(e => e.CmCheque).HasColumnName("CM_CHEQUE");
            entity.Property(e => e.CmDepRet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_DEP_RET");
            entity.Property(e => e.CmDeposit)
                .HasComputedColumnSql("(case [CM_DEP_RET] when 'D' then [CM_MONTO] else 0 end)", false)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_DEPOSIT");
            entity.Property(e => e.CmDescrip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CM_DESCRIP");
            entity.Property(e => e.CmFecha)
                .HasColumnType("datetime")
                .HasColumnName("CM_FECHA");
            entity.Property(e => e.CmInteres)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_INTERES");
            entity.Property(e => e.CmMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_MONTO");
            entity.Property(e => e.CmPresta).HasColumnName("CM_PRESTA");
            entity.Property(e => e.CmRetiro)
                .HasComputedColumnSql("(case [CM_DEP_RET] when 'D' then 0 else [CM_MONTO] end)", false)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_RETIRO");
            entity.Property(e => e.CmSalPre)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_SAL_PRE");
            entity.Property(e => e.CmStatus).HasColumnName("CM_STATUS");
            entity.Property(e => e.CmTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_TIPO");
            entity.Property(e => e.CmTotAho)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CM_TOT_AHO");
            entity.Property(e => e.CtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_CODIGO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PrReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PR_REFEREN");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");

            entity.HasOne(d => d.CtCodigoNavigation).WithMany(p => p.CtaMovs)
                .HasForeignKey(d => d.CtCodigo)
                .HasConstraintName("FK_CTA_MOVS_CTABANCO");
        });

        modelBuilder.Entity<Ctabanco>(entity =>
        {
            entity.HasKey(e => e.CtCodigo);

            entity.ToTable("CTABANCO");

            entity.Property(e => e.CtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CT_CODIGO");
            entity.Property(e => e.AhTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AH_TIPO");
            entity.Property(e => e.CtBanco)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CT_BANCO");
            entity.Property(e => e.CtNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CT_NOMBRE");
            entity.Property(e => e.CtNumCta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CT_NUM_CTA");
            entity.Property(e => e.CtNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CT_NUMERO");
            entity.Property(e => e.CtRepChk).HasColumnName("CT_REP_CHK");
            entity.Property(e => e.CtRepLiq).HasColumnName("CT_REP_LIQ");
            entity.Property(e => e.CtStatus).HasColumnName("CT_STATUS");
            entity.Property(e => e.CtTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CT_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.AhTipoNavigation).WithMany(p => p.Ctabancos)
                .HasForeignKey(d => d.AhTipo)
                .HasConstraintName("FK_CTABANCO_TAHORRO");
        });

        modelBuilder.Entity<CurAsi>(entity =>
        {
            entity.HasKey(e => new { e.RvFolio, e.SeFolio, e.CbCodigo });

            entity.ToTable("CUR_ASIS");

            entity.Property(e => e.RvFolio).HasColumnName("RV_FOLIO");
            entity.Property(e => e.SeFolio).HasColumnName("SE_FOLIO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CsAsistio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CS_ASISTIO");
            entity.Property(e => e.CsComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CS_COMENTA");
            entity.Property(e => e.CsEva1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_EVA_1");
            entity.Property(e => e.CsEva2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_EVA_2");
            entity.Property(e => e.CsEva3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_EVA_3");
            entity.Property(e => e.CsEvaFin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_EVA_FIN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.RvFolioNavigation).WithMany(p => p.CurAsis)
                .HasForeignKey(d => d.RvFolio)
                .HasConstraintName("FK_CUR_ASIS_RESERVA");

            entity.HasOne(d => d.Inscrito).WithMany(p => p.CurAsis)
                .HasForeignKey(d => new { d.SeFolio, d.CbCodigo })
                .HasConstraintName("FK_CUR_ASIS_INSCRITO");
        });

        modelBuilder.Entity<CurProg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CUR_PROG");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CpManual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CP_MANUAL");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.CuHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_HORAS");
            entity.Property(e => e.CuRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CU_REVISIO");
            entity.Property(e => e.EnLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN_LISTA");
            entity.Property(e => e.EnOpciona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN_OPCIONA");
            entity.Property(e => e.EpGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EP_GLOBAL");
            entity.Property(e => e.KcEvalua)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KC_EVALUA");
            entity.Property(e => e.KcFecPro)
                .HasColumnType("datetime")
                .HasColumnName("KC_FEC_PRO");
            entity.Property(e => e.KcFecTom)
                .HasColumnType("datetime")
                .HasColumnName("KC_FEC_TOM");
            entity.Property(e => e.KcHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KC_HORAS");
            entity.Property(e => e.KcProximo)
                .HasColumnType("datetime")
                .HasColumnName("KC_PROXIMO");
            entity.Property(e => e.KcRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KC_REVISIO");
            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
        });

        modelBuilder.Entity<CurRev>(entity =>
        {
            entity.HasKey(e => new { e.CuCodigo, e.ChRevisio, e.ChFecha });

            entity.ToTable("CUR_REV");

            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.ChRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CH_REVISIO");
            entity.Property(e => e.ChFecha)
                .HasColumnType("datetime")
                .HasColumnName("CH_FECHA");
            entity.Property(e => e.ChObserva)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CH_OBSERVA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CuCodigoNavigation).WithMany(p => p.CurRevs)
                .HasForeignKey(d => d.CuCodigo)
                .HasConstraintName("FK_CUR_REV_CURSO");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.CuCodigo);

            entity.ToTable("CURSO", tb => tb.HasTrigger("TU_CURSO"));

            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.AtCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AT_CODIGO");
            entity.Property(e => e.CuActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_ACTIVO");
            entity.Property(e => e.CuClase)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CLASE");
            entity.Property(e => e.CuClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CLASIFI");
            entity.Property(e => e.CuCosto1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_COSTO1");
            entity.Property(e => e.CuCosto2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_COSTO2");
            entity.Property(e => e.CuCosto3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_COSTO3");
            entity.Property(e => e.CuDocum)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CU_DOCUM");
            entity.Property(e => e.CuFecRev)
                .HasColumnType("datetime")
                .HasColumnName("CU_FEC_REV");
            entity.Property(e => e.CuFolio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CU_FOLIO");
            entity.Property(e => e.CuHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_HORAS");
            entity.Property(e => e.CuIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CU_INGLES");
            entity.Property(e => e.CuModalid).HasColumnName("CU_MODALID");
            entity.Property(e => e.CuNombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CU_NOMBRE");
            entity.Property(e => e.CuNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_NUMERO");
            entity.Property(e => e.CuObjetiv).HasColumnName("CU_OBJETIV");
            entity.Property(e => e.CuRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CU_REVISIO");
            entity.Property(e => e.CuStps)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_STPS");
            entity.Property(e => e.CuTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CU_TEXTO");
            entity.Property(e => e.CuTexto1)
                .HasColumnType("text")
                .HasColumnName("CU_TEXTO1");
            entity.Property(e => e.CuTexto2)
                .HasColumnType("text")
                .HasColumnName("CU_TEXTO2");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
        });

        modelBuilder.Entity<Cursopre>(entity =>
        {
            entity.HasKey(e => new { e.CuCodigo, e.CpCurso });

            entity.ToTable("CURSOPRE");

            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.CpCurso)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CP_CURSO");
            entity.Property(e => e.CpComenta)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CP_COMENTA");
            entity.Property(e => e.CpOpciona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CP_OPCIONA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CuCodigoNavigation).WithMany(p => p.Cursopres)
                .HasForeignKey(d => d.CuCodigo)
                .HasConstraintName("FK_CURSOPRE_CURSO");
        });

        modelBuilder.Entity<Declara>(entity =>
        {
            entity.HasKey(e => new { e.DcYear, e.CbCodigo });

            entity.ToTable("DECLARA");

            entity.Property(e => e.DcYear).HasColumnName("DC_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.DcCredito)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DC_CREDITO");
            entity.Property(e => e.DcGravado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DC_GRAVADO");
            entity.Property(e => e.DcTotPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DC_TOT_PER");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Declaras)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Declara_Colabora");
        });

        modelBuilder.Entity<DefectV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DEFECT_V");

            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CeFolio).HasColumnName("CE_FOLIO");
            entity.Property(e => e.CiArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_AREA");
            entity.Property(e => e.CiComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CI_COMENTA");
            entity.Property(e => e.CiFecha)
                .HasColumnType("datetime")
                .HasColumnName("CI_FECHA");
            entity.Property(e => e.CiFolio).HasColumnName("CI_FOLIO");
            entity.Property(e => e.CiHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_HORA");
            entity.Property(e => e.CiMuestra)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CI_MUESTRA");
            entity.Property(e => e.CiNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CI_NUMERO1");
            entity.Property(e => e.CiNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CI_NUMERO2");
            entity.Property(e => e.CiObserva)
                .HasColumnType("text")
                .HasColumnName("CI_OBSERVA");
            entity.Property(e => e.CiResult).HasColumnName("CI_RESULT");
            entity.Property(e => e.CiTamlote)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CI_TAMLOTE");
            entity.Property(e => e.CiTiempo).HasColumnName("CI_TIEMPO");
            entity.Property(e => e.CiTipo).HasColumnName("CI_TIPO");
            entity.Property(e => e.DeCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DE_CODIGO");
            entity.Property(e => e.DeComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DE_COMENTA");
            entity.Property(e => e.DeFolio).HasColumnName("DE_FOLIO");
            entity.Property(e => e.DePiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("DE_PIEZAS");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        modelBuilder.Entity<Defecto>(entity =>
        {
            entity.HasKey(e => new { e.CiFolio, e.DeFolio });

            entity.ToTable("DEFECTO");

            entity.Property(e => e.CiFolio).HasColumnName("CI_FOLIO");
            entity.Property(e => e.DeFolio).HasColumnName("DE_FOLIO");
            entity.Property(e => e.DeCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DE_CODIGO");
            entity.Property(e => e.DeComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DE_COMENTA");
            entity.Property(e => e.DePiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("DE_PIEZAS");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CiFolioNavigation).WithMany(p => p.Defectos)
                .HasForeignKey(d => d.CiFolio)
                .HasConstraintName("FK_DEFECTO_CED_INSP");

            entity.HasOne(d => d.DeCodigoNavigation).WithMany(p => p.Defectos)
                .HasForeignKey(d => d.DeCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEFECTO_TDEFECTO");
        });

        modelBuilder.Entity<Defstep>(entity =>
        {
            entity.HasKey(e => new { e.ArCodigo, e.DfSequenc });

            entity.ToTable("DEFSTEPS");

            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.DfSequenc).HasColumnName("DF_SEQUENC");
            entity.Property(e => e.DfStdHr)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("DF_STD_HR");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");

            entity.HasOne(d => d.ArCodigoNavigation).WithMany(p => p.Defsteps)
                .HasForeignKey(d => d.ArCodigo)
                .HasConstraintName("FK_DefSteps_Partes");
        });

        modelBuilder.Entity<DescFld>(entity =>
        {
            entity.HasKey(e => new { e.DtCodigo, e.DfOrden });

            entity.ToTable("DESC_FLD");

            entity.Property(e => e.DtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DT_CODIGO");
            entity.Property(e => e.DfOrden).HasColumnName("DF_ORDEN");
            entity.Property(e => e.DfCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DF_CAMPO");
            entity.Property(e => e.DfControl).HasColumnName("DF_CONTROL");
            entity.Property(e => e.DfLimite).HasColumnName("DF_LIMITE");
            entity.Property(e => e.DfTitulo)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DF_TITULO");
            entity.Property(e => e.DfValores)
                .HasColumnType("text")
                .HasColumnName("DF_VALORES");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.DtCodigoNavigation).WithMany(p => p.DescFlds)
                .HasForeignKey(d => d.DtCodigo)
                .HasConstraintName("FK_DESC_FLD_DESCTIPO");
        });

        modelBuilder.Entity<DescPto>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.DtCodigo, e.DpOrden });

            entity.ToTable("DESC_PTO");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.DtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DT_CODIGO");
            entity.Property(e => e.DpOrden).HasColumnName("DP_ORDEN");
            entity.Property(e => e.DpFech01)
                .HasColumnType("datetime")
                .HasColumnName("DP_FECH_01");
            entity.Property(e => e.DpMemo01)
                .HasColumnType("text")
                .HasColumnName("DP_MEMO_01");
            entity.Property(e => e.DpMemo02)
                .HasColumnType("text")
                .HasColumnName("DP_MEMO_02");
            entity.Property(e => e.DpMemo03)
                .HasColumnType("text")
                .HasColumnName("DP_MEMO_03");
            entity.Property(e => e.DpNume01)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DP_NUME_01");
            entity.Property(e => e.DpText01)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DP_TEXT_01");
            entity.Property(e => e.DpText02)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DP_TEXT_02");
            entity.Property(e => e.DpText03)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DP_TEXT_03");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.DtCodigoNavigation).WithMany(p => p.DescPtos)
                .HasForeignKey(d => d.DtCodigo)
                .HasConstraintName("FK_DESC_PTO_DESCTIPO");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.DescPtos)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_DESC_PTO_PERFIL");
        });

        modelBuilder.Entity<Desctipo>(entity =>
        {
            entity.HasKey(e => e.DtCodigo);

            entity.ToTable("DESCTIPO");

            entity.HasIndex(e => e.DtOrden, "XAK1DESCTIPO").IsUnique();

            entity.Property(e => e.DtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DT_CODIGO");
            entity.Property(e => e.DtIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DT_INGLES");
            entity.Property(e => e.DtNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DT_NOMBRE");
            entity.Property(e => e.DtNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DT_NUMERO");
            entity.Property(e => e.DtOrden).HasColumnName("DT_ORDEN");
            entity.Property(e => e.DtTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DT_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Diagnost>(entity =>
        {
            entity.HasKey(e => e.DaCodigo);

            entity.ToTable("DIAGNOST", tb => tb.HasTrigger("TU_DIAGNOST"));

            entity.Property(e => e.DaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DA_CODIGO");
            entity.Property(e => e.DaIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DA_INGLES");
            entity.Property(e => e.DaNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DA_NOMBRE");
            entity.Property(e => e.DaNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DA_NUMERO");
            entity.Property(e => e.DaTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DA_TEXTO");
            entity.Property(e => e.DaTipo).HasColumnName("DA_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Diccion>(entity =>
        {
            entity.HasKey(e => new { e.DiClasifi, e.DiNombre });

            entity.ToTable("DICCION");

            entity.HasIndex(e => new { e.DiClasifi, e.DiCalc }, "XIE1DICCION");

            entity.Property(e => e.DiClasifi).HasColumnName("DI_CLASIFI");
            entity.Property(e => e.DiNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DI_NOMBRE");
            entity.Property(e => e.DiAncho).HasColumnName("DI_ANCHO");
            entity.Property(e => e.DiCalc).HasColumnName("DI_CALC");
            entity.Property(e => e.DiClaves)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DI_CLAVES");
            entity.Property(e => e.DiConfi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DI_CONFI");
            entity.Property(e => e.DiMascara)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DI_MASCARA");
            entity.Property(e => e.DiNumero).HasColumnName("DI_NUMERO");
            entity.Property(e => e.DiOrden)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DI_ORDEN");
            entity.Property(e => e.DiRangoac).HasColumnName("DI_RANGOAC");
            entity.Property(e => e.DiRequier)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DI_REQUIER");
            entity.Property(e => e.DiTcorto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DI_TCORTO");
            entity.Property(e => e.DiTfield).HasColumnName("DI_TFIELD");
            entity.Property(e => e.DiTitulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DI_TITULO");
            entity.Property(e => e.DiTrango).HasColumnName("DI_TRANGO");
            entity.Property(e => e.DiValorac)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DI_VALORAC");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Dimensio>(entity =>
        {
            entity.HasKey(e => e.DmCodigo);

            entity.ToTable("DIMENSIO");

            entity.Property(e => e.DmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DM_CODIGO");
            entity.Property(e => e.DmDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DM_DESCRIP");
            entity.Property(e => e.DmIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DM_INGLES");
            entity.Property(e => e.DmNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("DM_NUMERO");
            entity.Property(e => e.DmTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DM_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Edocivil>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EDOCIVIL", tb => tb.HasTrigger("TU_EDOCIVIL"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Embarazo>(entity =>
        {
            entity.HasKey(e => new { e.ExCodigo, e.EmFecUm });

            entity.ToTable("EMBARAZO");

            entity.Property(e => e.ExCodigo).HasColumnName("EX_CODIGO");
            entity.Property(e => e.EmFecUm)
                .HasColumnType("datetime")
                .HasColumnName("EM_FEC_UM");
            entity.Property(e => e.EmComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_COMENTA");
            entity.Property(e => e.EmFecFin)
                .HasColumnType("datetime")
                .HasColumnName("EM_FEC_FIN");
            entity.Property(e => e.EmFecPp)
                .HasColumnType("datetime")
                .HasColumnName("EM_FEC_PP");
            entity.Property(e => e.EmFinal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EM_FINAL");
            entity.Property(e => e.EmIncFin)
                .HasColumnType("datetime")
                .HasColumnName("EM_INC_FIN");
            entity.Property(e => e.EmIncIni)
                .HasColumnType("datetime")
                .HasColumnName("EM_INC_INI");
            entity.Property(e => e.EmMortal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EM_MORTAL");
            entity.Property(e => e.EmNormal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EM_NORMAL");
            entity.Property(e => e.EmObsRie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EM_OBS_RIE");
            entity.Property(e => e.EmPosnat)
                .HasColumnType("datetime")
                .HasColumnName("EM_POSNAT");
            entity.Property(e => e.EmPrenat)
                .HasColumnType("datetime")
                .HasColumnName("EM_PRENAT");
            entity.Property(e => e.EmRiesgo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EM_RIESGO");
            entity.Property(e => e.EmTermino).HasColumnName("EM_TERMINO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.ExCodigoNavigation).WithMany(p => p.Embarazos)
                .HasForeignKey(d => d.ExCodigo)
                .HasConstraintName("FK_EMBARAZO_EXPEDIEN");
        });

        modelBuilder.Entity<EmpComp>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.CmCodigo });

            entity.ToTable("EMP_COMP");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CA_CODIGO");
            entity.Property(e => e.EcFecMod)
                .HasColumnType("datetime")
                .HasColumnName("EC_FEC_MOD");
            entity.Property(e => e.EcObserva)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EC_OBSERVA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.EmpComps)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_EMP_COMP_COLABORA");

            entity.HasOne(d => d.CmCodigoNavigation).WithMany(p => p.EmpComps)
                .HasForeignKey(d => d.CmCodigo)
                .HasConstraintName("FK_EMP_COMP_COMPETEN");
        });

        modelBuilder.Entity<EmpPlan>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AnCodigo });

            entity.ToTable("EMP_PLAN");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AnCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AN_CODIGO");
            entity.Property(e => e.EpFecFin)
                .HasColumnType("datetime")
                .HasColumnName("EP_FEC_FIN");
            entity.Property(e => e.EpFecIni)
                .HasColumnType("datetime")
                .HasColumnName("EP_FEC_INI");
            entity.Property(e => e.EpFecMod)
                .HasColumnType("datetime")
                .HasColumnName("EP_FEC_MOD");
            entity.Property(e => e.EpFecPro)
                .HasColumnType("datetime")
                .HasColumnName("EP_FEC_PRO");
            entity.Property(e => e.EpObserva)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EP_OBSERVA");
            entity.Property(e => e.EpResult)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EP_RESULT");
            entity.Property(e => e.EpTermino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EP_TERMINO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.AnCodigoNavigation).WithMany(p => p.EmpPlans)
                .HasForeignKey(d => d.AnCodigo)
                .HasConstraintName("FK_EMP_PLAN_ACCION");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.EmpPlans)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_EMP_PLAN_COLABORA");
        });

        modelBuilder.Entity<EmpProg>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.CuCodigo });

            entity.ToTable("EMP_PROG");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.EpDias).HasColumnName("EP_DIAS");
            entity.Property(e => e.EpFecha)
                .HasColumnType("datetime")
                .HasColumnName("EP_FECHA");
            entity.Property(e => e.EpGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EP_GLOBAL");
            entity.Property(e => e.EpOpciona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EP_OPCIONA");
            entity.Property(e => e.EpPordias)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EP_PORDIAS");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.EmpProgs)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_EMP_PROG_COLABORA");

            entity.HasOne(d => d.CuCodigoNavigation).WithMany(p => p.EmpProgs)
                .HasForeignKey(d => d.CuCodigo)
                .HasConstraintName("FK_EMP_PROG_CURSO");
        });

        modelBuilder.Entity<EmpleadosXVerificar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EMPLEADOS_X_VERIFICAR");

            entity.Property(e => e.CbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ACTIVO");
            entity.Property(e => e.CbApeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_APE_MAT");
            entity.Property(e => e.CbApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_APE_PAT");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbCurp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CURP");
            entity.Property(e => e.CbFecNac)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_NAC");
            entity.Property(e => e.CbNombres)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_NOMBRES");
            entity.Property(e => e.CbRecontr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_RECONTR");
            entity.Property(e => e.CbRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_RFC");
            entity.Property(e => e.CbSegsoc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_SEGSOC");
            entity.Property(e => e.CbSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_SEXO");
            entity.Property(e => e.Foto)
                .HasColumnType("image")
                .HasColumnName("FOTO");
            entity.Property(e => e.Prettyname)
                .HasMaxLength(93)
                .IsUnicode(false)
                .HasColumnName("PRETTYNAME");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
        });

        modelBuilder.Entity<EntNac>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ENT_NAC");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.TbCurp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CURP");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Entfed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ENTFED");

            entity.Property(e => e.EnCodigo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("EN_CODIGO");
            entity.Property(e => e.EnDescrip)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("EN_DESCRIP");
            entity.Property(e => e.EnEstado)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("EN_ESTADO");
        });

        modelBuilder.Entity<Entidad>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("ENTIDAD", tb => tb.HasTrigger("TU_ENTIDAD"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbCurp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CURP");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbStps).HasColumnName("TB_STPS");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Entnivel>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.CuCodigo, e.EtCodigo });

            entity.ToTable("ENTNIVEL");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.EtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ET_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.Entrena).WithMany(p => p.Entnivels)
                .HasForeignKey(d => new { d.PuCodigo, d.CuCodigo })
                .HasConstraintName("FK_EntNivel_Entrena");
        });

        modelBuilder.Entity<Entrena>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.CuCodigo });

            entity.ToTable("ENTRENA");

            entity.HasIndex(e => e.CuCodigo, "XIE1ENTRENA");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.EnDias).HasColumnName("EN_DIAS");
            entity.Property(e => e.EnLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN_LISTA");
            entity.Property(e => e.EnOpciona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN_OPCIONA");
            entity.Property(e => e.EnReDias).HasColumnName("EN_RE_DIAS");
            entity.Property(e => e.EnReprog)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN_REPROG");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CuCodigoNavigation).WithMany(p => p.Entrenas)
                .HasForeignKey(d => d.CuCodigo)
                .HasConstraintName("FK_Entrena_Curso");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.Entrenas)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_Entrena_Puesto");
        });

        modelBuilder.Entity<Establec>(entity =>
        {
            entity.HasKey(e => e.EsCodigo);

            entity.ToTable("ESTABLEC");

            entity.Property(e => e.EsCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ES_CODIGO");
            entity.Property(e => e.EsActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ES_ACTIVO");
            entity.Property(e => e.EsCalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_CALLE");
            entity.Property(e => e.EsCiudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_CIUDAD");
            entity.Property(e => e.EsCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ES_CODPOST");
            entity.Property(e => e.EsColonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_COLONIA");
            entity.Property(e => e.EsElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_ELEMENT");
            entity.Property(e => e.EsEntidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ES_ENTIDAD");
            entity.Property(e => e.EsIngles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ES_INGLES");
            entity.Property(e => e.EsNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("ES_NUMERO");
            entity.Property(e => e.EsNumext)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ES_NUMEXT");
            entity.Property(e => e.EsNumint)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ES_NUMINT");
            entity.Property(e => e.EsTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ES_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Estudio>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("ESTUDIOS", tb => tb.HasTrigger("TU_ESTUDIOS"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EvCodigo);

            entity.ToTable("EVENTO");

            entity.Property(e => e.EvCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_CODIGO");
            entity.Property(e => e.EvActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_ACTIVO");
            entity.Property(e => e.EvAlta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_ALTA");
            entity.Property(e => e.EvAntFin).HasColumnName("EV_ANT_FIN");
            entity.Property(e => e.EvAntIni).HasColumnName("EV_ANT_INI");
            entity.Property(e => e.EvAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_AUTOSAL");
            entity.Property(e => e.EvBaja)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_BAJA");
            entity.Property(e => e.EvCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EV_CAMPO");
            entity.Property(e => e.EvClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_CLASIFI");
            entity.Property(e => e.EvContrat)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_CONTRAT");
            entity.Property(e => e.EvDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EV_DESCRIP");
            entity.Property(e => e.EvFecBss)
                .HasColumnType("datetime")
                .HasColumnName("EV_FEC_BSS");
            entity.Property(e => e.EvFecCon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_FEC_CON");
            entity.Property(e => e.EvFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EV_FILTRO");
            entity.Property(e => e.EvFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EV_FORMULA");
            entity.Property(e => e.EvIncluye).HasColumnName("EV_INCLUYE");
            entity.Property(e => e.EvKardex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_KARDEX");
            entity.Property(e => e.EvMAntig)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_M_ANTIG");
            entity.Property(e => e.EvMSvac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_M_SVAC");
            entity.Property(e => e.EvMTvac).HasColumnName("EV_M_TVAC");
            entity.Property(e => e.EvMotBaj)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_MOT_BAJ");
            entity.Property(e => e.EvNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL1");
            entity.Property(e => e.EvNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL2");
            entity.Property(e => e.EvNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL3");
            entity.Property(e => e.EvNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL4");
            entity.Property(e => e.EvNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL5");
            entity.Property(e => e.EvNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL6");
            entity.Property(e => e.EvNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL7");
            entity.Property(e => e.EvNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL8");
            entity.Property(e => e.EvNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_NIVEL9");
            entity.Property(e => e.EvNomnume).HasColumnName("EV_NOMNUME");
            entity.Property(e => e.EvNomtipo).HasColumnName("EV_NOMTIPO");
            entity.Property(e => e.EvNomyear).HasColumnName("EV_NOMYEAR");
            entity.Property(e => e.EvOtras1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_OTRAS_1");
            entity.Property(e => e.EvOtras2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_OTRAS_2");
            entity.Property(e => e.EvOtras3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_OTRAS_3");
            entity.Property(e => e.EvOtras4)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_OTRAS_4");
            entity.Property(e => e.EvOtras5)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_OTRAS_5");
            entity.Property(e => e.EvPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_PATRON");
            entity.Property(e => e.EvPriorid).HasColumnName("EV_PRIORID");
            entity.Property(e => e.EvPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_PUESTO");
            entity.Property(e => e.EvQuery)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_QUERY");
            entity.Property(e => e.EvSalario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EV_SALARIO");
            entity.Property(e => e.EvTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_TABLASS");
            entity.Property(e => e.EvTabula)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_TABULA");
            entity.Property(e => e.EvTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_TURNO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Expedien>(entity =>
        {
            entity.HasKey(e => e.ExCodigo);

            entity.ToTable("EXPEDIEN");

            entity.Property(e => e.ExCodigo)
                .ValueGeneratedNever()
                .HasColumnName("EX_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ExApeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EX_APE_MAT");
            entity.Property(e => e.ExApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EX_APE_PAT");
            entity.Property(e => e.ExCalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EX_CALLE");
            entity.Property(e => e.ExCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EX_CIUDAD");
            entity.Property(e => e.ExCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("EX_CODPOST");
            entity.Property(e => e.ExColonia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EX_COLONIA");
            entity.Property(e => e.ExEmbFin)
                .HasColumnType("datetime")
                .HasColumnName("EX_EMB_FIN");
            entity.Property(e => e.ExEmbIni)
                .HasColumnType("datetime")
                .HasColumnName("EX_EMB_INI");
            entity.Property(e => e.ExEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_ESTADO");
            entity.Property(e => e.ExFecIni)
                .HasColumnType("datetime")
                .HasColumnName("EX_FEC_INI");
            entity.Property(e => e.ExFecNac)
                .HasColumnType("datetime")
                .HasColumnName("EX_FEC_NAC");
            entity.Property(e => e.ExGBol01)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL01");
            entity.Property(e => e.ExGBol02)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL02");
            entity.Property(e => e.ExGBol03)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL03");
            entity.Property(e => e.ExGBol04)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL04");
            entity.Property(e => e.ExGBol05)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL05");
            entity.Property(e => e.ExGBol06)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL06");
            entity.Property(e => e.ExGBol07)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL07");
            entity.Property(e => e.ExGBol08)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL08");
            entity.Property(e => e.ExGBol09)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL09");
            entity.Property(e => e.ExGBol10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL10");
            entity.Property(e => e.ExGBol11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL11");
            entity.Property(e => e.ExGBol12)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL12");
            entity.Property(e => e.ExGBol13)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL13");
            entity.Property(e => e.ExGBol14)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL14");
            entity.Property(e => e.ExGBol15)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL15");
            entity.Property(e => e.ExGBol16)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL16");
            entity.Property(e => e.ExGBol17)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL17");
            entity.Property(e => e.ExGBol18)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL18");
            entity.Property(e => e.ExGBol19)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL19");
            entity.Property(e => e.ExGBol20)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL20");
            entity.Property(e => e.ExGBol21)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL21");
            entity.Property(e => e.ExGBol22)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL22");
            entity.Property(e => e.ExGBol23)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL23");
            entity.Property(e => e.ExGBol24)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL24");
            entity.Property(e => e.ExGBol25)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL25");
            entity.Property(e => e.ExGBol26)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL26");
            entity.Property(e => e.ExGBol27)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL27");
            entity.Property(e => e.ExGBol28)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL28");
            entity.Property(e => e.ExGBol29)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL29");
            entity.Property(e => e.ExGBol30)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL30");
            entity.Property(e => e.ExGBol31)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL31");
            entity.Property(e => e.ExGBol32)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL32");
            entity.Property(e => e.ExGBol33)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL33");
            entity.Property(e => e.ExGBol34)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL34");
            entity.Property(e => e.ExGBol35)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL35");
            entity.Property(e => e.ExGBol36)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL36");
            entity.Property(e => e.ExGBol37)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL37");
            entity.Property(e => e.ExGBol38)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL38");
            entity.Property(e => e.ExGBol39)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL39");
            entity.Property(e => e.ExGBol40)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL40");
            entity.Property(e => e.ExGBol41)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL41");
            entity.Property(e => e.ExGBol42)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL42");
            entity.Property(e => e.ExGBol43)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL43");
            entity.Property(e => e.ExGBol44)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL44");
            entity.Property(e => e.ExGBol45)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL45");
            entity.Property(e => e.ExGBol46)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL46");
            entity.Property(e => e.ExGBol47)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL47");
            entity.Property(e => e.ExGBol48)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL48");
            entity.Property(e => e.ExGBol49)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL49");
            entity.Property(e => e.ExGBol50)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL50");
            entity.Property(e => e.ExGBol51)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL51");
            entity.Property(e => e.ExGBol52)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL52");
            entity.Property(e => e.ExGBol53)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL53");
            entity.Property(e => e.ExGBol54)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL54");
            entity.Property(e => e.ExGBol55)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL55");
            entity.Property(e => e.ExGBol56)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL56");
            entity.Property(e => e.ExGBol57)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL57");
            entity.Property(e => e.ExGBol58)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL58");
            entity.Property(e => e.ExGBol59)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL59");
            entity.Property(e => e.ExGBol60)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL60");
            entity.Property(e => e.ExGBol61)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL61");
            entity.Property(e => e.ExGBol62)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL62");
            entity.Property(e => e.ExGBol63)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL63");
            entity.Property(e => e.ExGBol64)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL64");
            entity.Property(e => e.ExGBol65)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL65");
            entity.Property(e => e.ExGBol66)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL66");
            entity.Property(e => e.ExGBol67)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL67");
            entity.Property(e => e.ExGBol68)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL68");
            entity.Property(e => e.ExGBol69)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL69");
            entity.Property(e => e.ExGBol70)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL70");
            entity.Property(e => e.ExGBol71)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL71");
            entity.Property(e => e.ExGBol72)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL72");
            entity.Property(e => e.ExGBol73)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL73");
            entity.Property(e => e.ExGBol74)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL74");
            entity.Property(e => e.ExGBol75)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL75");
            entity.Property(e => e.ExGBol76)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL76");
            entity.Property(e => e.ExGBol77)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL77");
            entity.Property(e => e.ExGBol78)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL78");
            entity.Property(e => e.ExGBol79)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL79");
            entity.Property(e => e.ExGBol80)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL80");
            entity.Property(e => e.ExGBol81)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL81");
            entity.Property(e => e.ExGBol82)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL82");
            entity.Property(e => e.ExGBol83)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL83");
            entity.Property(e => e.ExGBol84)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL84");
            entity.Property(e => e.ExGBol85)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL85");
            entity.Property(e => e.ExGBol86)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL86");
            entity.Property(e => e.ExGBol87)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL87");
            entity.Property(e => e.ExGBol88)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL88");
            entity.Property(e => e.ExGBol89)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL89");
            entity.Property(e => e.ExGBol90)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL90");
            entity.Property(e => e.ExGBol91)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL91");
            entity.Property(e => e.ExGBol92)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL92");
            entity.Property(e => e.ExGBol93)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL93");
            entity.Property(e => e.ExGBol94)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL94");
            entity.Property(e => e.ExGBol95)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL95");
            entity.Property(e => e.ExGBol96)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL96");
            entity.Property(e => e.ExGBol97)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL97");
            entity.Property(e => e.ExGBol98)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL98");
            entity.Property(e => e.ExGBol99)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_BOL99");
            entity.Property(e => e.ExGDes01)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES01");
            entity.Property(e => e.ExGDes02)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES02");
            entity.Property(e => e.ExGDes03)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES03");
            entity.Property(e => e.ExGDes04)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES04");
            entity.Property(e => e.ExGDes05)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES05");
            entity.Property(e => e.ExGDes06)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES06");
            entity.Property(e => e.ExGDes07)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES07");
            entity.Property(e => e.ExGDes08)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES08");
            entity.Property(e => e.ExGDes09)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES09");
            entity.Property(e => e.ExGDes10)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES10");
            entity.Property(e => e.ExGDes11)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES11");
            entity.Property(e => e.ExGDes12)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES12");
            entity.Property(e => e.ExGDes13)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES13");
            entity.Property(e => e.ExGDes14)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES14");
            entity.Property(e => e.ExGDes15)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES15");
            entity.Property(e => e.ExGDes16)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES16");
            entity.Property(e => e.ExGDes17)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES17");
            entity.Property(e => e.ExGDes18)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES18");
            entity.Property(e => e.ExGDes19)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES19");
            entity.Property(e => e.ExGDes20)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES20");
            entity.Property(e => e.ExGDes21)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES21");
            entity.Property(e => e.ExGDes22)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES22");
            entity.Property(e => e.ExGDes23)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES23");
            entity.Property(e => e.ExGDes24)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES24");
            entity.Property(e => e.ExGDes25)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES25");
            entity.Property(e => e.ExGDes26)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES26");
            entity.Property(e => e.ExGDes27)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES27");
            entity.Property(e => e.ExGDes28)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES28");
            entity.Property(e => e.ExGDes29)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES29");
            entity.Property(e => e.ExGDes30)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES30");
            entity.Property(e => e.ExGDes31)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES31");
            entity.Property(e => e.ExGDes32)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES32");
            entity.Property(e => e.ExGDes33)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES33");
            entity.Property(e => e.ExGDes34)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES34");
            entity.Property(e => e.ExGDes35)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES35");
            entity.Property(e => e.ExGDes36)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES36");
            entity.Property(e => e.ExGDes37)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES37");
            entity.Property(e => e.ExGDes38)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES38");
            entity.Property(e => e.ExGDes39)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES39");
            entity.Property(e => e.ExGDes40)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES40");
            entity.Property(e => e.ExGDes41)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES41");
            entity.Property(e => e.ExGDes42)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES42");
            entity.Property(e => e.ExGDes43)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES43");
            entity.Property(e => e.ExGDes44)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES44");
            entity.Property(e => e.ExGDes45)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES45");
            entity.Property(e => e.ExGDes46)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES46");
            entity.Property(e => e.ExGDes47)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES47");
            entity.Property(e => e.ExGDes48)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES48");
            entity.Property(e => e.ExGDes49)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES49");
            entity.Property(e => e.ExGDes50)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES50");
            entity.Property(e => e.ExGDes51)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES51");
            entity.Property(e => e.ExGDes52)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES52");
            entity.Property(e => e.ExGDes53)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES53");
            entity.Property(e => e.ExGDes54)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES54");
            entity.Property(e => e.ExGDes55)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES55");
            entity.Property(e => e.ExGDes56)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES56");
            entity.Property(e => e.ExGDes57)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES57");
            entity.Property(e => e.ExGDes58)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES58");
            entity.Property(e => e.ExGDes59)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES59");
            entity.Property(e => e.ExGDes60)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES60");
            entity.Property(e => e.ExGDes61)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES61");
            entity.Property(e => e.ExGDes62)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES62");
            entity.Property(e => e.ExGDes63)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES63");
            entity.Property(e => e.ExGDes64)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES64");
            entity.Property(e => e.ExGDes65)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES65");
            entity.Property(e => e.ExGDes66)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES66");
            entity.Property(e => e.ExGDes67)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES67");
            entity.Property(e => e.ExGDes68)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES68");
            entity.Property(e => e.ExGDes69)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES69");
            entity.Property(e => e.ExGDes70)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES70");
            entity.Property(e => e.ExGDes71)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES71");
            entity.Property(e => e.ExGDes72)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES72");
            entity.Property(e => e.ExGDes73)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES73");
            entity.Property(e => e.ExGDes74)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES74");
            entity.Property(e => e.ExGDes75)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES75");
            entity.Property(e => e.ExGDes76)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES76");
            entity.Property(e => e.ExGDes77)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES77");
            entity.Property(e => e.ExGDes78)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES78");
            entity.Property(e => e.ExGDes79)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES79");
            entity.Property(e => e.ExGDes80)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES80");
            entity.Property(e => e.ExGDes81)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES81");
            entity.Property(e => e.ExGDes82)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES82");
            entity.Property(e => e.ExGDes83)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES83");
            entity.Property(e => e.ExGDes84)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES84");
            entity.Property(e => e.ExGDes85)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES85");
            entity.Property(e => e.ExGDes86)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES86");
            entity.Property(e => e.ExGDes87)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES87");
            entity.Property(e => e.ExGDes88)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES88");
            entity.Property(e => e.ExGDes89)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES89");
            entity.Property(e => e.ExGDes90)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES90");
            entity.Property(e => e.ExGDes91)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES91");
            entity.Property(e => e.ExGDes92)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES92");
            entity.Property(e => e.ExGDes93)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES93");
            entity.Property(e => e.ExGDes94)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES94");
            entity.Property(e => e.ExGDes95)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES95");
            entity.Property(e => e.ExGDes96)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES96");
            entity.Property(e => e.ExGDes97)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES97");
            entity.Property(e => e.ExGDes98)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES98");
            entity.Property(e => e.ExGDes99)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_DES99");
            entity.Property(e => e.ExGLog01)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG01");
            entity.Property(e => e.ExGLog02)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG02");
            entity.Property(e => e.ExGLog03)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG03");
            entity.Property(e => e.ExGLog04)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG04");
            entity.Property(e => e.ExGLog05)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG05");
            entity.Property(e => e.ExGLog06)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG06");
            entity.Property(e => e.ExGLog07)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG07");
            entity.Property(e => e.ExGLog08)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG08");
            entity.Property(e => e.ExGLog09)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG09");
            entity.Property(e => e.ExGLog10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG10");
            entity.Property(e => e.ExGLog11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG11");
            entity.Property(e => e.ExGLog12)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG12");
            entity.Property(e => e.ExGLog13)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG13");
            entity.Property(e => e.ExGLog14)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG14");
            entity.Property(e => e.ExGLog15)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG15");
            entity.Property(e => e.ExGLog16)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG16");
            entity.Property(e => e.ExGLog17)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG17");
            entity.Property(e => e.ExGLog18)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG18");
            entity.Property(e => e.ExGLog19)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG19");
            entity.Property(e => e.ExGLog20)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG20");
            entity.Property(e => e.ExGLog21)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG21");
            entity.Property(e => e.ExGLog22)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG22");
            entity.Property(e => e.ExGLog23)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG23");
            entity.Property(e => e.ExGLog24)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG24");
            entity.Property(e => e.ExGLog25)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG25");
            entity.Property(e => e.ExGLog26)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG26");
            entity.Property(e => e.ExGLog27)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG27");
            entity.Property(e => e.ExGLog28)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG28");
            entity.Property(e => e.ExGLog29)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG29");
            entity.Property(e => e.ExGLog30)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG30");
            entity.Property(e => e.ExGLog31)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG31");
            entity.Property(e => e.ExGLog32)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG32");
            entity.Property(e => e.ExGLog33)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG33");
            entity.Property(e => e.ExGLog34)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG34");
            entity.Property(e => e.ExGLog35)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG35");
            entity.Property(e => e.ExGLog36)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG36");
            entity.Property(e => e.ExGLog37)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG37");
            entity.Property(e => e.ExGLog38)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG38");
            entity.Property(e => e.ExGLog39)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG39");
            entity.Property(e => e.ExGLog40)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG40");
            entity.Property(e => e.ExGLog41)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG41");
            entity.Property(e => e.ExGLog42)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG42");
            entity.Property(e => e.ExGLog43)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG43");
            entity.Property(e => e.ExGLog44)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG44");
            entity.Property(e => e.ExGLog45)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG45");
            entity.Property(e => e.ExGLog46)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG46");
            entity.Property(e => e.ExGLog47)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG47");
            entity.Property(e => e.ExGLog48)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG48");
            entity.Property(e => e.ExGLog49)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG49");
            entity.Property(e => e.ExGLog50)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG50");
            entity.Property(e => e.ExGLog51)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG51");
            entity.Property(e => e.ExGLog52)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG52");
            entity.Property(e => e.ExGLog53)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG53");
            entity.Property(e => e.ExGLog54)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG54");
            entity.Property(e => e.ExGLog55)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG55");
            entity.Property(e => e.ExGLog56)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG56");
            entity.Property(e => e.ExGLog57)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG57");
            entity.Property(e => e.ExGLog58)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG58");
            entity.Property(e => e.ExGLog59)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG59");
            entity.Property(e => e.ExGLog60)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG60");
            entity.Property(e => e.ExGLog61)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG61");
            entity.Property(e => e.ExGLog62)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG62");
            entity.Property(e => e.ExGLog63)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG63");
            entity.Property(e => e.ExGLog64)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG64");
            entity.Property(e => e.ExGLog65)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG65");
            entity.Property(e => e.ExGLog66)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG66");
            entity.Property(e => e.ExGLog67)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG67");
            entity.Property(e => e.ExGLog68)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG68");
            entity.Property(e => e.ExGLog69)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG69");
            entity.Property(e => e.ExGLog70)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG70");
            entity.Property(e => e.ExGLog71)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG71");
            entity.Property(e => e.ExGLog72)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG72");
            entity.Property(e => e.ExGLog73)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG73");
            entity.Property(e => e.ExGLog74)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG74");
            entity.Property(e => e.ExGLog75)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG75");
            entity.Property(e => e.ExGLog76)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG76");
            entity.Property(e => e.ExGLog77)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG77");
            entity.Property(e => e.ExGLog78)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG78");
            entity.Property(e => e.ExGLog79)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG79");
            entity.Property(e => e.ExGLog80)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG80");
            entity.Property(e => e.ExGLog81)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG81");
            entity.Property(e => e.ExGLog82)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG82");
            entity.Property(e => e.ExGLog83)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG83");
            entity.Property(e => e.ExGLog84)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG84");
            entity.Property(e => e.ExGLog85)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG85");
            entity.Property(e => e.ExGLog86)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG86");
            entity.Property(e => e.ExGLog87)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG87");
            entity.Property(e => e.ExGLog88)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG88");
            entity.Property(e => e.ExGLog89)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG89");
            entity.Property(e => e.ExGLog90)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG90");
            entity.Property(e => e.ExGLog91)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG91");
            entity.Property(e => e.ExGLog92)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG92");
            entity.Property(e => e.ExGLog93)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG93");
            entity.Property(e => e.ExGLog94)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG94");
            entity.Property(e => e.ExGLog95)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG95");
            entity.Property(e => e.ExGLog96)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG96");
            entity.Property(e => e.ExGLog97)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG97");
            entity.Property(e => e.ExGLog98)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG98");
            entity.Property(e => e.ExGLog99)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_G_LOG99");
            entity.Property(e => e.ExGNum01)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM01");
            entity.Property(e => e.ExGNum02)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM02");
            entity.Property(e => e.ExGNum03)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM03");
            entity.Property(e => e.ExGNum04)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM04");
            entity.Property(e => e.ExGNum05)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM05");
            entity.Property(e => e.ExGNum06)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM06");
            entity.Property(e => e.ExGNum07)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM07");
            entity.Property(e => e.ExGNum08)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM08");
            entity.Property(e => e.ExGNum09)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM09");
            entity.Property(e => e.ExGNum10)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM10");
            entity.Property(e => e.ExGNum11)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM11");
            entity.Property(e => e.ExGNum12)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM12");
            entity.Property(e => e.ExGNum13)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM13");
            entity.Property(e => e.ExGNum14)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM14");
            entity.Property(e => e.ExGNum15)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM15");
            entity.Property(e => e.ExGNum16)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM16");
            entity.Property(e => e.ExGNum17)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM17");
            entity.Property(e => e.ExGNum18)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM18");
            entity.Property(e => e.ExGNum19)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM19");
            entity.Property(e => e.ExGNum20)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM20");
            entity.Property(e => e.ExGNum21)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM21");
            entity.Property(e => e.ExGNum22)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM22");
            entity.Property(e => e.ExGNum23)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM23");
            entity.Property(e => e.ExGNum24)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM24");
            entity.Property(e => e.ExGNum25)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM25");
            entity.Property(e => e.ExGNum26)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM26");
            entity.Property(e => e.ExGNum27)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM27");
            entity.Property(e => e.ExGNum28)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM28");
            entity.Property(e => e.ExGNum29)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM29");
            entity.Property(e => e.ExGNum30)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("EX_G_NUM30");
            entity.Property(e => e.ExGTex01)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX01");
            entity.Property(e => e.ExGTex02)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX02");
            entity.Property(e => e.ExGTex03)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX03");
            entity.Property(e => e.ExGTex04)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX04");
            entity.Property(e => e.ExGTex05)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX05");
            entity.Property(e => e.ExGTex06)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX06");
            entity.Property(e => e.ExGTex07)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX07");
            entity.Property(e => e.ExGTex08)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX08");
            entity.Property(e => e.ExGTex09)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX09");
            entity.Property(e => e.ExGTex10)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX10");
            entity.Property(e => e.ExGTex11)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX11");
            entity.Property(e => e.ExGTex12)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX12");
            entity.Property(e => e.ExGTex13)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX13");
            entity.Property(e => e.ExGTex14)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX14");
            entity.Property(e => e.ExGTex15)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX15");
            entity.Property(e => e.ExGTex16)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX16");
            entity.Property(e => e.ExGTex17)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX17");
            entity.Property(e => e.ExGTex18)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX18");
            entity.Property(e => e.ExGTex19)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX19");
            entity.Property(e => e.ExGTex20)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX20");
            entity.Property(e => e.ExGTex21)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX21");
            entity.Property(e => e.ExGTex22)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX22");
            entity.Property(e => e.ExGTex23)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX23");
            entity.Property(e => e.ExGTex24)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX24");
            entity.Property(e => e.ExGTex25)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX25");
            entity.Property(e => e.ExGTex26)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX26");
            entity.Property(e => e.ExGTex27)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX27");
            entity.Property(e => e.ExGTex28)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX28");
            entity.Property(e => e.ExGTex29)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX29");
            entity.Property(e => e.ExGTex30)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX30");
            entity.Property(e => e.ExGTex31)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX31");
            entity.Property(e => e.ExGTex32)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX32");
            entity.Property(e => e.ExGTex33)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX33");
            entity.Property(e => e.ExGTex34)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX34");
            entity.Property(e => e.ExGTex35)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX35");
            entity.Property(e => e.ExGTex36)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX36");
            entity.Property(e => e.ExGTex37)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX37");
            entity.Property(e => e.ExGTex38)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX38");
            entity.Property(e => e.ExGTex39)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX39");
            entity.Property(e => e.ExGTex40)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX40");
            entity.Property(e => e.ExGTex41)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX41");
            entity.Property(e => e.ExGTex42)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX42");
            entity.Property(e => e.ExGTex43)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX43");
            entity.Property(e => e.ExGTex44)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX44");
            entity.Property(e => e.ExGTex45)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX45");
            entity.Property(e => e.ExGTex46)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX46");
            entity.Property(e => e.ExGTex47)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX47");
            entity.Property(e => e.ExGTex48)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX48");
            entity.Property(e => e.ExGTex49)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX49");
            entity.Property(e => e.ExGTex50)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX50");
            entity.Property(e => e.ExGTex51)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX51");
            entity.Property(e => e.ExGTex52)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX52");
            entity.Property(e => e.ExGTex53)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX53");
            entity.Property(e => e.ExGTex54)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX54");
            entity.Property(e => e.ExGTex55)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX55");
            entity.Property(e => e.ExGTex56)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX56");
            entity.Property(e => e.ExGTex57)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX57");
            entity.Property(e => e.ExGTex58)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX58");
            entity.Property(e => e.ExGTex59)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX59");
            entity.Property(e => e.ExGTex60)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX60");
            entity.Property(e => e.ExGTex61)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX61");
            entity.Property(e => e.ExGTex62)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX62");
            entity.Property(e => e.ExGTex63)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX63");
            entity.Property(e => e.ExGTex64)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX64");
            entity.Property(e => e.ExGTex65)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX65");
            entity.Property(e => e.ExGTex66)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX66");
            entity.Property(e => e.ExGTex67)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX67");
            entity.Property(e => e.ExGTex68)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX68");
            entity.Property(e => e.ExGTex69)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX69");
            entity.Property(e => e.ExGTex70)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX70");
            entity.Property(e => e.ExGTex71)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX71");
            entity.Property(e => e.ExGTex72)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX72");
            entity.Property(e => e.ExGTex73)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX73");
            entity.Property(e => e.ExGTex74)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX74");
            entity.Property(e => e.ExGTex75)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX75");
            entity.Property(e => e.ExGTex76)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX76");
            entity.Property(e => e.ExGTex77)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX77");
            entity.Property(e => e.ExGTex78)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX78");
            entity.Property(e => e.ExGTex79)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX79");
            entity.Property(e => e.ExGTex80)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX80");
            entity.Property(e => e.ExGTex81)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX81");
            entity.Property(e => e.ExGTex82)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX82");
            entity.Property(e => e.ExGTex83)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX83");
            entity.Property(e => e.ExGTex84)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX84");
            entity.Property(e => e.ExGTex85)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX85");
            entity.Property(e => e.ExGTex86)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX86");
            entity.Property(e => e.ExGTex87)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX87");
            entity.Property(e => e.ExGTex88)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX88");
            entity.Property(e => e.ExGTex89)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX89");
            entity.Property(e => e.ExGTex90)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX90");
            entity.Property(e => e.ExGTex91)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX91");
            entity.Property(e => e.ExGTex92)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX92");
            entity.Property(e => e.ExGTex93)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX93");
            entity.Property(e => e.ExGTex94)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX94");
            entity.Property(e => e.ExGTex95)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX95");
            entity.Property(e => e.ExGTex96)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX96");
            entity.Property(e => e.ExGTex97)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX97");
            entity.Property(e => e.ExGTex98)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX98");
            entity.Property(e => e.ExGTex99)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EX_G_TEX99");
            entity.Property(e => e.ExNombres)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EX_NOMBRES");
            entity.Property(e => e.ExNumExt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EX_NUM_EXT");
            entity.Property(e => e.ExNumInt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EX_NUM_INT");
            entity.Property(e => e.ExObserva)
                .HasColumnType("text")
                .HasColumnName("EX_OBSERVA");
            entity.Property(e => e.ExSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EX_SEXO");
            entity.Property(e => e.ExTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EX_TEL");
            entity.Property(e => e.ExTipo).HasColumnName("EX_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PrettyExp)
                .HasMaxLength(93)
                .IsUnicode(false)
                .HasComputedColumnSql("([EX_APE_PAT] + ' ' + [EX_APE_MAT] + ', ' + [EX_NOMBRES])", false)
                .HasColumnName("PRETTY_EXP");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Extra1>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA1", tb => tb.HasTrigger("TU_EXTRA1"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra10>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA10", tb => tb.HasTrigger("TU_EXTRA10"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra11>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA11", tb => tb.HasTrigger("TU_EXTRA11"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra12>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA12", tb => tb.HasTrigger("TU_EXTRA12"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra13>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA13", tb => tb.HasTrigger("TU_EXTRA13"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra14>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA14", tb => tb.HasTrigger("TU_EXTRA14"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra2>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA2", tb => tb.HasTrigger("TU_EXTRA2"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra3>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA3", tb => tb.HasTrigger("TU_EXTRA3"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra4>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA4", tb => tb.HasTrigger("TU_EXTRA4"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra5>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA5", tb => tb.HasTrigger("TU_EXTRA5"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra6>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA6", tb => tb.HasTrigger("TU_EXTRA6"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra7>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA7", tb => tb.HasTrigger("TU_EXTRA7"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra8>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA8", tb => tb.HasTrigger("TU_EXTRA8"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Extra9>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("EXTRA9", tb => tb.HasTrigger("TU_EXTRA9"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Falta>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero, e.CbCodigo, e.FaDiaHor, e.FaFecIni, e.FaMotivo });

            entity.ToTable("FALTAS");

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.FaDiaHor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FA_DIA_HOR");
            entity.Property(e => e.FaFecIni)
                .HasColumnType("datetime")
                .HasColumnName("FA_FEC_INI");
            entity.Property(e => e.FaMotivo).HasColumnName("FA_MOTIVO");
            entity.Property(e => e.FaDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FA_DIAS");
            entity.Property(e => e.FaHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FA_HORAS");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.Nomina).WithMany(p => p.Falta)
                .HasForeignKey(d => new { d.PeYear, d.PeTipo, d.PeNumero, d.CbCodigo })
                .HasConstraintName("FK_Faltas_Nomina");
        });

        modelBuilder.Entity<FamPto>(entity =>
        {
            entity.HasKey(e => e.FpCodigo);

            entity.ToTable("FAM_PTO", tb => tb.HasTrigger("TU_FAM_PTO"));

            entity.Property(e => e.FpCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FP_CODIGO");
            entity.Property(e => e.FpDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FP_DESCRIP");
            entity.Property(e => e.FpIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FP_INGLES");
            entity.Property(e => e.FpNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FP_NUMERO");
            entity.Property(e => e.FpTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FP_TEXTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Festivo>(entity =>
        {
            entity.HasKey(e => new { e.TuCodigo, e.FeMes, e.FeDia, e.FeYear });

            entity.ToTable("FESTIVO");

            entity.Property(e => e.TuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_CODIGO");
            entity.Property(e => e.FeMes).HasColumnName("FE_MES");
            entity.Property(e => e.FeDia).HasColumnName("FE_DIA");
            entity.Property(e => e.FeYear).HasColumnName("FE_YEAR");
            entity.Property(e => e.FeCambio)
                .HasColumnType("datetime")
                .HasColumnName("FE_CAMBIO");
            entity.Property(e => e.FeDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FE_DESCRIP");
            entity.Property(e => e.FeTipo).HasColumnName("FE_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.TuCodigoNavigation).WithMany(p => p.Festivos)
                .HasForeignKey(d => d.TuCodigo)
                .HasConstraintName("FK_Festivo_Turno");
        });

        modelBuilder.Entity<Folio>(entity =>
        {
            entity.HasKey(e => e.FlCodigo);

            entity.ToTable("FOLIO");

            entity.Property(e => e.FlCodigo)
                .ValueGeneratedNever()
                .HasColumnName("FL_CODIGO");
            entity.Property(e => e.FlCeros)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_CEROS");
            entity.Property(e => e.FlDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FL_DESCRIP");
            entity.Property(e => e.FlFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FL_FILTRO");
            entity.Property(e => e.FlFinal).HasColumnName("FL_FINAL");
            entity.Property(e => e.FlInicial).HasColumnName("FL_INICIAL");
            entity.Property(e => e.FlMoneda)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FL_MONEDA");
            entity.Property(e => e.FlMonto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FL_MONTO");
            entity.Property(e => e.FlRepite)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FL_REPITE");
            entity.Property(e => e.FlReporte).HasColumnName("FL_REPORTE");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.QuCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CODIGO");
        });

        modelBuilder.Entity<FonCre>(entity =>
        {
            entity.HasKey(e => new { e.FtYear, e.FtMonth, e.PrTipo, e.CbCodigo, e.PrReferen });

            entity.ToTable("FON_CRE");

            entity.Property(e => e.FtYear).HasColumnName("FT_YEAR");
            entity.Property(e => e.FtMonth).HasColumnName("FT_MONTH");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PrReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PR_REFEREN");
            entity.Property(e => e.FcAjuste)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FC_AJUSTE");
            entity.Property(e => e.FcNomina)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FC_NOMINA");
            entity.Property(e => e.FcRetenc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FC_RETENC");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.FonEmp).WithMany(p => p.FonCres)
                .HasForeignKey(d => new { d.FtYear, d.FtMonth, d.PrTipo, d.CbCodigo })
                .HasConstraintName("FK_Fon_Cre_Empleado");
        });

        modelBuilder.Entity<FonEmp>(entity =>
        {
            entity.HasKey(e => new { e.FtYear, e.FtMonth, e.PrTipo, e.CbCodigo }).IsClustered(false);

            entity.ToTable("FON_EMP");

            entity.Property(e => e.FtYear).HasColumnName("FT_YEAR");
            entity.Property(e => e.FtMonth).HasColumnName("FT_MONTH");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.FeAjuste)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FE_AJUSTE");
            entity.Property(e => e.FeCuantos).HasColumnName("FE_CUANTOS");
            entity.Property(e => e.FeFecha1)
                .HasColumnType("datetime")
                .HasColumnName("FE_FECHA1");
            entity.Property(e => e.FeFecha2)
                .HasColumnType("datetime")
                .HasColumnName("FE_FECHA2");
            entity.Property(e => e.FeIncide)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FE_INCIDE");
            entity.Property(e => e.FeNomina)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FE_NOMINA");
            entity.Property(e => e.FeRetenc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FE_RETENC");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.FonTot).WithMany(p => p.FonEmps)
                .HasForeignKey(d => new { d.FtYear, d.FtMonth, d.PrTipo })
                .HasConstraintName("FK_Fon_Emp_Total");
        });

        modelBuilder.Entity<FonTot>(entity =>
        {
            entity.HasKey(e => new { e.FtYear, e.FtMonth, e.PrTipo });

            entity.ToTable("FON_TOT");

            entity.Property(e => e.FtYear).HasColumnName("FT_YEAR");
            entity.Property(e => e.FtMonth).HasColumnName("FT_MONTH");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");
            entity.Property(e => e.FtAjuste)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FT_AJUSTE");
            entity.Property(e => e.FtBajas).HasColumnName("FT_BAJAS");
            entity.Property(e => e.FtCuantos).HasColumnName("FT_CUANTOS");
            entity.Property(e => e.FtDetalle)
                .HasColumnType("text")
                .HasColumnName("FT_DETALLE");
            entity.Property(e => e.FtEmplead).HasColumnName("FT_EMPLEAD");
            entity.Property(e => e.FtIncapa).HasColumnName("FT_INCAPA");
            entity.Property(e => e.FtNomina)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FT_NOMINA");
            entity.Property(e => e.FtRetenc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("FT_RETENC");
            entity.Property(e => e.FtStatus).HasColumnName("FT_STATUS");
            entity.Property(e => e.FtTajust)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FT_TAJUST");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Global>(entity =>
        {
            entity.HasKey(e => e.GlCodigo);

            entity.ToTable("GLOBAL");

            entity.Property(e => e.GlCodigo)
                .ValueGeneratedNever()
                .HasColumnName("GL_CODIGO");
            entity.Property(e => e.GlCaptura)
                .HasColumnType("datetime")
                .HasColumnName("GL_CAPTURA");
            entity.Property(e => e.GlDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GL_DESCRIP");
            entity.Property(e => e.GlFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GL_FORMULA");
            entity.Property(e => e.GlNivel).HasColumnName("GL_NIVEL");
            entity.Property(e => e.GlSql)
                .IsUnicode(false)
                .HasColumnName("GL_SQL");
            entity.Property(e => e.GlTipo).HasColumnName("GL_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<GrAdAcc>(entity =>
        {
            entity.HasKey(e => new { e.CmCodigo, e.GrCodigo, e.GxCodigo });

            entity.ToTable("GR_AD_ACC");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.GxCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GX_CODIGO");
            entity.Property(e => e.GxDerecho).HasColumnName("GX_DERECHO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<GrupoAd>(entity =>
        {
            entity.HasKey(e => e.GxCodigo);

            entity.ToTable("GRUPO_AD", tb =>
                {
                    tb.HasTrigger("TD_GRUPO_AD");
                    tb.HasTrigger("TU_GRUPO_AD");
                });

            entity.Property(e => e.GxCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GX_CODIGO");
            entity.Property(e => e.GxPosicio).HasColumnName("GX_POSICIO");
            entity.Property(e => e.GxTitulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GX_TITULO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<GrupoEx>(entity =>
        {
            entity.HasKey(e => e.GxCodigo);

            entity.ToTable("GRUPO_EX", tb =>
                {
                    tb.HasTrigger("TD_GRUPO_EX");
                    tb.HasTrigger("TU_GRUPO_EX");
                });

            entity.Property(e => e.GxCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GX_CODIGO");
            entity.Property(e => e.GxPosicio).HasColumnName("GX_POSICIO");
            entity.Property(e => e.GxTitulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GX_TITULO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.HoCodigo);

            entity.ToTable("HORARIO", tb => tb.HasTrigger("TU_HORARIO"));

            entity.Property(e => e.HoCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_CODIGO");
            entity.Property(e => e.HoActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_ACTIVO");
            entity.Property(e => e.HoAddEat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_ADD_EAT");
            entity.Property(e => e.HoChkEat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_CHK_EAT");
            entity.Property(e => e.HoComer).HasColumnName("HO_COMER");
            entity.Property(e => e.HoDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HO_DESCRIP");
            entity.Property(e => e.HoDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("HO_DOBLES");
            entity.Property(e => e.HoExtCom).HasColumnName("HO_EXT_COM");
            entity.Property(e => e.HoExtFij)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("HO_EXT_FIJ");
            entity.Property(e => e.HoExtMin).HasColumnName("HO_EXT_MIN");
            entity.Property(e => e.HoIgnEat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_IGN_EAT");
            entity.Property(e => e.HoInBrk)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_IN_BRK");
            entity.Property(e => e.HoInEat)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_IN_EAT");
            entity.Property(e => e.HoInTard).HasColumnName("HO_IN_TARD");
            entity.Property(e => e.HoInTemp).HasColumnName("HO_IN_TEMP");
            entity.Property(e => e.HoIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HO_INGLES");
            entity.Property(e => e.HoIntime)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_INTIME");
            entity.Property(e => e.HoJornada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("HO_JORNADA");
            entity.Property(e => e.HoLastout)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_LASTOUT");
            entity.Property(e => e.HoMinEat).HasColumnName("HO_MIN_EAT");
            entity.Property(e => e.HoNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("HO_NUMERO");
            entity.Property(e => e.HoOuTard).HasColumnName("HO_OU_TARD");
            entity.Property(e => e.HoOuTemp).HasColumnName("HO_OU_TEMP");
            entity.Property(e => e.HoOutBrk)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_OUT_BRK");
            entity.Property(e => e.HoOutEat)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_OUT_EAT");
            entity.Property(e => e.HoOuttime)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_OUTTIME");
            entity.Property(e => e.HoPares)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("HO_PARES");
            entity.Property(e => e.HoTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HO_TEXTO");
            entity.Property(e => e.HoTipo).HasColumnName("HO_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Horario1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HORARIOS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsFixedLength()
                .HasColumnName("descripcion");
            entity.Property(e => e.DiaNum)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("dia_num");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdHorarios).HasColumnName("id_horarios");
            entity.Property(e => e.IdJornada)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("id_jornada");
        });

        modelBuilder.Entity<HorarioPersonal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("horario_personal");

            entity.Property(e => e.CbCodigo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CB_CODIGO");
            entity.Property(e => e.FechInicio)
                .HasColumnType("datetime")
                .HasColumnName("FECH_INICIO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdHorario)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ID_HORARIO");
        });

        modelBuilder.Entity<Imagen>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.ImTipo });

            entity.ToTable("IMAGEN");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ImTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IM_TIPO");
            entity.Property(e => e.ImBlob)
                .HasColumnType("image")
                .HasColumnName("IM_BLOB");
            entity.Property(e => e.ImObserva)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IM_OBSERVA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Imagens)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Imagen_Colabora");
        });

        modelBuilder.Entity<Incapaci>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.InFecIni });

            entity.ToTable("INCAPACI");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.InFecIni)
                .HasColumnType("datetime")
                .HasColumnName("IN_FEC_INI");
            entity.Property(e => e.InCaptura)
                .HasColumnType("datetime")
                .HasColumnName("IN_CAPTURA");
            entity.Property(e => e.InComenta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IN_COMENTA");
            entity.Property(e => e.InDias).HasColumnName("IN_DIAS");
            entity.Property(e => e.InDiassub)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IN_DIASSUB");
            entity.Property(e => e.InFecFin)
                .HasColumnType("datetime")
                .HasColumnName("IN_FEC_FIN");
            entity.Property(e => e.InFin).HasColumnName("IN_FIN");
            entity.Property(e => e.InMotivo).HasColumnName("IN_MOTIVO");
            entity.Property(e => e.InNomnume).HasColumnName("IN_NOMNUME");
            entity.Property(e => e.InNomtipo).HasColumnName("IN_NOMTIPO");
            entity.Property(e => e.InNomyear).HasColumnName("IN_NOMYEAR");
            entity.Property(e => e.InNumero)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IN_NUMERO");
            entity.Property(e => e.InSuaFin)
                .HasColumnType("datetime")
                .HasColumnName("IN_SUA_FIN");
            entity.Property(e => e.InSuaIni)
                .HasColumnType("datetime")
                .HasColumnName("IN_SUA_INI");
            entity.Property(e => e.InTasaIp)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("IN_TASA_IP");
            entity.Property(e => e.InTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IN_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Incapacis)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Incapaci_Colabora");
        });

        modelBuilder.Entity<Inciden>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("INCIDEN", tb => tb.HasTrigger("TU_INCIDEN"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIncapa).HasColumnName("TB_INCAPA");
            entity.Property(e => e.TbInciden).HasColumnName("TB_INCIDEN");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbPermiso).HasColumnName("TB_PERMISO");
            entity.Property(e => e.TbSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_SISTEMA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Inscrito>(entity =>
        {
            entity.HasKey(e => new { e.SeFolio, e.CbCodigo });

            entity.ToTable("INSCRITO");

            entity.Property(e => e.SeFolio).HasColumnName("SE_FOLIO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.IcComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IC_COMENTA");
            entity.Property(e => e.IcEva1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IC_EVA_1");
            entity.Property(e => e.IcEva2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IC_EVA_2");
            entity.Property(e => e.IcEva3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IC_EVA_3");
            entity.Property(e => e.IcEvaFin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("IC_EVA_FIN");
            entity.Property(e => e.IcFecBaj)
                .HasColumnType("datetime")
                .HasColumnName("IC_FEC_BAJ");
            entity.Property(e => e.IcFecIns)
                .HasColumnType("datetime")
                .HasColumnName("IC_FEC_INS");
            entity.Property(e => e.IcHorIns)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IC_HOR_INS");
            entity.Property(e => e.IcStatus).HasColumnName("IC_STATUS");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Inscritos)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_INSCRITO_COLABORA");

            entity.HasOne(d => d.SeFolioNavigation).WithMany(p => p.Inscritos)
                .HasForeignKey(d => d.SeFolio)
                .HasConstraintName("FK_INSCRITO_SESION");
        });

        modelBuilder.Entity<Invitum>(entity =>
        {
            entity.HasKey(e => e.IvCodigo);

            entity.ToTable("INVITA");

            entity.Property(e => e.IvCodigo)
                .ValueGeneratedNever()
                .HasColumnName("IV_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.IvActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IV_ACTIVO");
            entity.Property(e => e.IvFecFin)
                .HasColumnType("datetime")
                .HasColumnName("IV_FEC_FIN");
            entity.Property(e => e.IvFecIni)
                .HasColumnType("datetime")
                .HasColumnName("IV_FEC_INI");
            entity.Property(e => e.IvIdNum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IV_ID_NUM");
            entity.Property(e => e.IvNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IV_NOMBRE");
            entity.Property(e => e.IvTope1).HasColumnName("IV_TOPE_1");
            entity.Property(e => e.IvTope2).HasColumnName("IV_TOPE_2");
            entity.Property(e => e.IvTope3).HasColumnName("IV_TOPE_3");
            entity.Property(e => e.IvTope4).HasColumnName("IV_TOPE_4");
            entity.Property(e => e.IvTope5).HasColumnName("IV_TOPE_5");
            entity.Property(e => e.IvTope6).HasColumnName("IV_TOPE_6");
            entity.Property(e => e.IvTope7).HasColumnName("IV_TOPE_7");
            entity.Property(e => e.IvTope8).HasColumnName("IV_TOPE_8");
            entity.Property(e => e.IvTope9).HasColumnName("IV_TOPE_9");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Jornada>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JORNADAS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("descripcion");
            entity.Property(e => e.HE1)
                .HasColumnType("datetime")
                .HasColumnName("H_E_1");
            entity.Property(e => e.HE3)
                .HasColumnType("datetime")
                .HasColumnName("H_E_3");
            entity.Property(e => e.HS2)
                .HasColumnType("datetime")
                .HasColumnName("H_S_2");
            entity.Property(e => e.HS4)
                .HasColumnType("datetime")
                .HasColumnName("H_S_4");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdJornada).HasColumnName("id_jornada");
            entity.Property(e => e.TolF1)
                .HasColumnType("datetime")
                .HasColumnName("tol_f_1");
            entity.Property(e => e.TolF2)
                .HasColumnType("datetime")
                .HasColumnName("tol_f_2");
            entity.Property(e => e.TolF3)
                .HasColumnType("datetime")
                .HasColumnName("tol_f_3");
            entity.Property(e => e.TolF4)
                .HasColumnType("datetime")
                .HasColumnName("tol_f_4");
            entity.Property(e => e.TotalI1)
                .HasColumnType("datetime")
                .HasColumnName("total_i_1");
            entity.Property(e => e.TotalI2)
                .HasColumnType("datetime")
                .HasColumnName("total_i_2");
            entity.Property(e => e.TotalI3)
                .HasColumnType("datetime")
                .HasColumnName("total_i_3");
            entity.Property(e => e.TotalI4)
                .HasColumnType("datetime")
                .HasColumnName("total_i_4");
        });

        modelBuilder.Entity<KarArea>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.KaFecha, e.KaHora });

            entity.ToTable("KAR_AREA");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.KaFecha)
                .HasColumnType("datetime")
                .HasColumnName("KA_FECHA");
            entity.Property(e => e.KaHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KA_HORA");
            entity.Property(e => e.CbArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AREA");
            entity.Property(e => e.KaFecMov)
                .HasColumnType("datetime")
                .HasColumnName("KA_FEC_MOV");
            entity.Property(e => e.KaHorMov)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KA_HOR_MOV");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.KarAreas)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_KAR_AREA_COLABORA");
        });

        modelBuilder.Entity<KarCert>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.KiFecCer, e.CiCodigo });

            entity.ToTable("KAR_CERT");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.KiFecCer)
                .HasColumnType("datetime")
                .HasColumnName("KI_FEC_CER");
            entity.Property(e => e.CiCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_CODIGO");
            entity.Property(e => e.KiAprobo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KI_APROBO");
            entity.Property(e => e.KiCalif1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KI_CALIF_1");
            entity.Property(e => e.KiCalif2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KI_CALIF_2");
            entity.Property(e => e.KiCalif3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KI_CALIF_3");
            entity.Property(e => e.KiFolio)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KI_FOLIO");
            entity.Property(e => e.KiObserva)
                .HasColumnType("text")
                .HasColumnName("KI_OBSERVA");
            entity.Property(e => e.KiRenovar).HasColumnName("KI_RENOVAR");
            entity.Property(e => e.KiSinod1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KI_SINOD_1");
            entity.Property(e => e.KiSinod2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KI_SINOD_2");
            entity.Property(e => e.KiSinod3)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KI_SINOD_3");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.KarCerts)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_KAR_CERT_COLABORA");

            entity.HasOne(d => d.CiCodigoNavigation).WithMany(p => p.KarCerts)
                .HasForeignKey(d => d.CiCodigo)
                .HasConstraintName("FK_KAR_CERT_CERTIFIC");
        });

        modelBuilder.Entity<KarFija>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.CbFecha, e.CbTipo, e.KfFolio });

            entity.ToTable("KAR_FIJA");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbFecha)
                .HasColumnType("datetime")
                .HasColumnName("CB_FECHA");
            entity.Property(e => e.CbTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TIPO");
            entity.Property(e => e.KfFolio).HasColumnName("KF_FOLIO");
            entity.Property(e => e.KfCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KF_CODIGO");
            entity.Property(e => e.KfGravado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KF_GRAVADO");
            entity.Property(e => e.KfImss).HasColumnName("KF_IMSS");
            entity.Property(e => e.KfMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KF_MONTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.Kardex).WithMany(p => p.KarFijas)
                .HasForeignKey(d => new { d.CbCodigo, d.CbFecha, d.CbTipo })
                .HasConstraintName("FK_Kar_Fija_Kardex");
        });

        modelBuilder.Entity<KarTool>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.KtFecIni, e.ToCodigo, e.KtReferen });

            entity.ToTable("KAR_TOOL");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.KtFecIni)
                .HasColumnType("datetime")
                .HasColumnName("KT_FEC_INI");
            entity.Property(e => e.ToCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TO_CODIGO");
            entity.Property(e => e.KtReferen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KT_REFEREN");
            entity.Property(e => e.KtActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KT_ACTIVO");
            entity.Property(e => e.KtComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KT_COMENTA");
            entity.Property(e => e.KtFecFin)
                .HasColumnType("datetime")
                .HasColumnName("KT_FEC_FIN");
            entity.Property(e => e.KtMotFin)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KT_MOT_FIN");
            entity.Property(e => e.KtTalla)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KT_TALLA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.KarTools)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Kar_Tool_Colabora");

            entity.HasOne(d => d.ToCodigoNavigation).WithMany(p => p.KarTools)
                .HasForeignKey(d => d.ToCodigo)
                .HasConstraintName("FK_Kar_Tool_Tool");
        });

        modelBuilder.Entity<Karcurso>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.KcFecTom, e.CuCodigo });

            entity.ToTable("KARCURSO", tb =>
                {
                    tb.HasTrigger("TI_KARCURSO");
                    tb.HasTrigger("TU_KARCURSO");
                });

            entity.HasIndex(e => e.CuCodigo, "XIE1KARCURSO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.KcFecTom)
                .HasColumnType("datetime")
                .HasColumnName("KC_FEC_TOM");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.CbClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLASIFI");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.KcEst)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("KC_EST");
            entity.Property(e => e.KcEvalua)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KC_EVALUA");
            entity.Property(e => e.KcFecFin)
                .HasColumnType("datetime")
                .HasColumnName("KC_FEC_FIN");
            entity.Property(e => e.KcFecprog)
                .HasColumnType("datetime")
                .HasColumnName("KC_FECPROG");
            entity.Property(e => e.KcHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("KC_HORAS");
            entity.Property(e => e.KcNoStps).HasColumnName("KC_NO_STPS");
            entity.Property(e => e.KcRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KC_REVISIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
            entity.Property(e => e.SeFolio).HasColumnName("SE_FOLIO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Karcursos)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Karcurso_Colabora");
        });

        modelBuilder.Entity<Kardex>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.CbFecha, e.CbTipo });

            entity.ToTable("KARDEX");

            entity.HasIndex(e => new { e.CbCodigo, e.CbFecha, e.CbNivel }, "XIE1KARDEX");

            entity.HasIndex(e => new { e.CbTipo, e.CbFecha }, "XIE2KARDEX");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbFecha)
                .HasColumnType("datetime")
                .HasColumnName("CB_FECHA");
            entity.Property(e => e.CbTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TIPO");
            entity.Property(e => e.CbAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AUTOSAL");
            entity.Property(e => e.CbClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLASIFI");
            entity.Property(e => e.CbComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CB_COMENTA");
            entity.Property(e => e.CbContrat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CONTRAT");
            entity.Property(e => e.CbFacInt)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("CB_FAC_INT");
            entity.Property(e => e.CbFecAnt)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ANT");
            entity.Property(e => e.CbFecCap)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_CAP");
            entity.Property(e => e.CbFecCon)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_CON");
            entity.Property(e => e.CbFecCov)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_COV");
            entity.Property(e => e.CbFecIng)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ING");
            entity.Property(e => e.CbFecInt)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_INT");
            entity.Property(e => e.CbFecRev)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_REV");
            entity.Property(e => e.CbFecSal)
                .HasComputedColumnSql("(case when ([CB_FEC_REV] > [CB_FEC_INT]) then [CB_FEC_REV] else [CB_FEC_INT] end)", false)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_SAL");
            entity.Property(e => e.CbFecha2)
                .HasColumnType("datetime")
                .HasColumnName("CB_FECHA_2");
            entity.Property(e => e.CbGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_GLOBAL");
            entity.Property(e => e.CbModNv1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV1");
            entity.Property(e => e.CbModNv2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV2");
            entity.Property(e => e.CbModNv3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV3");
            entity.Property(e => e.CbModNv4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV4");
            entity.Property(e => e.CbModNv5)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV5");
            entity.Property(e => e.CbModNv6)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV6");
            entity.Property(e => e.CbModNv7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV7");
            entity.Property(e => e.CbModNv8)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV8");
            entity.Property(e => e.CbModNv9)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOD_NV9");
            entity.Property(e => e.CbMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_MONTO");
            entity.Property(e => e.CbMotBaj)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_MOT_BAJ");
            entity.Property(e => e.CbNivel).HasColumnName("CB_NIVEL");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.CbNomina).HasColumnName("CB_NOMINA");
            entity.Property(e => e.CbNomnume).HasColumnName("CB_NOMNUME");
            entity.Property(e => e.CbNomtipo).HasColumnName("CB_NOMTIPO");
            entity.Property(e => e.CbNomyear).HasColumnName("CB_NOMYEAR");
            entity.Property(e => e.CbNota)
                .HasColumnType("text")
                .HasColumnName("CB_NOTA");
            entity.Property(e => e.CbOldInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_OLD_INT");
            entity.Property(e => e.CbOldSal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_OLD_SAL");
            entity.Property(e => e.CbOtrasP)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_OTRAS_P");
            entity.Property(e => e.CbPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PATRON");
            entity.Property(e => e.CbPerVar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_PER_VAR");
            entity.Property(e => e.CbPlaza).HasColumnName("CB_PLAZA");
            entity.Property(e => e.CbPreInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_PRE_INT");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CbRangoS)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("CB_RANGO_S");
            entity.Property(e => e.CbRecontr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_RECONTR");
            entity.Property(e => e.CbReingre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_REINGRE");
            entity.Property(e => e.CbSalInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SAL_INT");
            entity.Property(e => e.CbSalTot)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SAL_TOT");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CbStatus).HasColumnName("CB_STATUS");
            entity.Property(e => e.CbTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TABLASS");
            entity.Property(e => e.CbTipRev)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when ([CB_FEC_REV] = [CB_FEC_ING]) then 'ALTA' else 'CAMBIO' end)", false)
                .HasColumnName("CB_TIP_REV");
            entity.Property(e => e.CbTotGra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_TOT_GRA");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.CbZonaGe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ZONA_GE");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Kardex_Colabora");

            entity.HasOne(d => d.CbTipoNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.CbTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Kardex_TKardex");
        });

        modelBuilder.Entity<Karinf>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.KiFecha, e.KiTipo });

            entity.ToTable("KARINF");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.KiFecha)
                .HasColumnType("datetime")
                .HasColumnName("KI_FECHA");
            entity.Property(e => e.KiTipo).HasColumnName("KI_TIPO");
            entity.Property(e => e.CbInfAnt)
                .HasColumnType("datetime")
                .HasColumnName("CB_INF_ANT");
            entity.Property(e => e.CbInfcred)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_INFCRED");
            entity.Property(e => e.CbInfdism)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_INFDISM");
            entity.Property(e => e.CbInftasa)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CB_INFTASA");
            entity.Property(e => e.CbInftipo).HasColumnName("CB_INFTIPO");
            entity.Property(e => e.KiCaptura)
                .HasColumnType("datetime")
                .HasColumnName("KI_CAPTURA");
            entity.Property(e => e.KiComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KI_COMENTA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Karinfs)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_KINF_Colabora");
        });

        modelBuilder.Entity<LCalculo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("L_CALCULO");

            entity.Property(e => e.CalcLog)
                .IsUnicode(false)
                .HasColumnName("CALC_LOG");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ClFecha)
                .HasColumnType("datetime")
                .HasColumnName("CL_FECHA");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
        });

        modelBuilder.Entity<Lectura>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.LxFecha, e.LxHora, e.LxWorder, e.LxOpera });

            entity.ToTable("LECTURAS");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.LxFecha)
                .HasColumnType("datetime")
                .HasColumnName("LX_FECHA");
            entity.Property(e => e.LxHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LX_HORA");
            entity.Property(e => e.LxWorder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LX_WORDER");
            entity.Property(e => e.LxOpera)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LX_OPERA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.LxFolio).HasColumnName("LX_FOLIO");
            entity.Property(e => e.LxLinxId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LX_LINX_ID");
            entity.Property(e => e.LxModula1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LX_MODULA1");
            entity.Property(e => e.LxModula2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LX_MODULA2");
            entity.Property(e => e.LxModula3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LX_MODULA3");
            entity.Property(e => e.LxNumero)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LX_NUMERO");
            entity.Property(e => e.LxPiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("LX_PIEZAS");
            entity.Property(e => e.LxStatus).HasColumnName("LX_STATUS");
            entity.Property(e => e.LxTmuerto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LX_TMUERTO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Lecturas)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Lecturas_Colabora");
        });

        modelBuilder.Entity<LeyImss>(entity =>
        {
            entity.HasKey(e => e.SsInicial);

            entity.ToTable("LEY_IMSS");

            entity.Property(e => e.SsInicial)
                .HasColumnType("datetime")
                .HasColumnName("SS_INICIAL");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.SsLA1061)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_A1061");
            entity.Property(e => e.SsLA1062)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_A1062");
            entity.Property(e => e.SsLA107)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_A107");
            entity.Property(e => e.SsLA25)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_A25");
            entity.Property(e => e.SsLCv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_CV");
            entity.Property(e => e.SsLGuard)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_GUARD");
            entity.Property(e => e.SsLInfo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_INFO");
            entity.Property(e => e.SsLIv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_IV");
            entity.Property(e => e.SsLRt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_RT");
            entity.Property(e => e.SsLSar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_L_SAR");
            entity.Property(e => e.SsMaximo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SS_MAXIMO");
            entity.Property(e => e.SsOA1061)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_A1061");
            entity.Property(e => e.SsOA1062)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_A1062");
            entity.Property(e => e.SsOA107)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_A107");
            entity.Property(e => e.SsOA25)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_A25");
            entity.Property(e => e.SsOCv)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_CV");
            entity.Property(e => e.SsOGuard)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_GUARD");
            entity.Property(e => e.SsOInfo)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_INFO");
            entity.Property(e => e.SsOIv)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_IV");
            entity.Property(e => e.SsOSar)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_O_SAR");
            entity.Property(e => e.SsPA1061)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_A1061");
            entity.Property(e => e.SsPA1062)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_A1062");
            entity.Property(e => e.SsPA107)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_A107");
            entity.Property(e => e.SsPA25)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_A25");
            entity.Property(e => e.SsPCv)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_CV");
            entity.Property(e => e.SsPGuard)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_GUARD");
            entity.Property(e => e.SsPInfo)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_INFO");
            entity.Property(e => e.SsPIv)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_IV");
            entity.Property(e => e.SsPSar)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("SS_P_SAR");
        });

        modelBuilder.Entity<LiqEmp>(entity =>
        {
            entity.HasKey(e => new { e.LsPatron, e.LsYear, e.LsMonth, e.LsTipo, e.CbCodigo }).IsClustered(false);

            entity.ToTable("LIQ_EMP");

            entity.Property(e => e.LsPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LS_PATRON");
            entity.Property(e => e.LsYear).HasColumnName("LS_YEAR");
            entity.Property(e => e.LsMonth).HasColumnName("LS_MONTH");
            entity.Property(e => e.LsTipo).HasColumnName("LS_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.LeAcumula)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_ACUMULA");
            entity.Property(e => e.LeApoVol)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_APO_VOL");
            entity.Property(e => e.LeBimAnt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_BIM_ANT");
            entity.Property(e => e.LeBimSig)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_BIM_SIG");
            entity.Property(e => e.LeCesVej)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_CES_VEJ");
            entity.Property(e => e.LeDiasBm).HasColumnName("LE_DIAS_BM");
            entity.Property(e => e.LeDiasCo).HasColumnName("LE_DIAS_CO");
            entity.Property(e => e.LeEymDin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_EYM_DIN");
            entity.Property(e => e.LeEymEsp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_EYM_ESP");
            entity.Property(e => e.LeEymExc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_EYM_EXC");
            entity.Property(e => e.LeEymFij)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_EYM_FIJ");
            entity.Property(e => e.LeGuarder)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_GUARDER");
            entity.Property(e => e.LeImssOb)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_IMSS_OB");
            entity.Property(e => e.LeImssPa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_IMSS_PA");
            entity.Property(e => e.LeInfAmo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_INF_AMO");
            entity.Property(e => e.LeInfPat)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_INF_PAT");
            entity.Property(e => e.LeInvVid)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_INV_VID");
            entity.Property(e => e.LeProv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_PROV");
            entity.Property(e => e.LeRetiro)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_RETIRO");
            entity.Property(e => e.LeRiesgos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_RIESGOS");
            entity.Property(e => e.LeStatus).HasColumnName("LE_STATUS");
            entity.Property(e => e.LeTotIms)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_TOT_IMS");
            entity.Property(e => e.LeTotInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_TOT_INF");
            entity.Property(e => e.LeTotRet)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_TOT_RET");
            entity.Property(e => e.LeVaGozo).HasColumnName("LE_VA_GOZO");
            entity.Property(e => e.LeVaPago).HasColumnName("LE_VA_PAGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.LiqImss).WithMany(p => p.LiqEmps)
                .HasForeignKey(d => new { d.LsPatron, d.LsYear, d.LsMonth, d.LsTipo })
                .HasConstraintName("FK_Liq_Emp_Liq_IMSS");
        });

        modelBuilder.Entity<LiqImss>(entity =>
        {
            entity.HasKey(e => new { e.LsPatron, e.LsYear, e.LsMonth, e.LsTipo });

            entity.ToTable("LIQ_IMSS");

            entity.Property(e => e.LsPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LS_PATRON");
            entity.Property(e => e.LsYear).HasColumnName("LS_YEAR");
            entity.Property(e => e.LsMonth).HasColumnName("LS_MONTH");
            entity.Property(e => e.LsTipo).HasColumnName("LS_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.LsActAmo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_ACT_AMO");
            entity.Property(e => e.LsActApo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_ACT_APO");
            entity.Property(e => e.LsActIms)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_ACT_IMS");
            entity.Property(e => e.LsActInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_ACT_INF");
            entity.Property(e => e.LsActRet)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_ACT_RET");
            entity.Property(e => e.LsApoVol)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_APO_VOL");
            entity.Property(e => e.LsCesVej)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_CES_VEJ");
            entity.Property(e => e.LsDes20)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LS_DES_20");
            entity.Property(e => e.LsDiasBm).HasColumnName("LS_DIAS_BM");
            entity.Property(e => e.LsDiasCo).HasColumnName("LS_DIAS_CO");
            entity.Property(e => e.LsEymDin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_EYM_DIN");
            entity.Property(e => e.LsEymEsp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_EYM_ESP");
            entity.Property(e => e.LsEymExc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_EYM_EXC");
            entity.Property(e => e.LsEymFij)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_EYM_FIJ");
            entity.Property(e => e.LsFacAct)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("LS_FAC_ACT");
            entity.Property(e => e.LsFacRec)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("LS_FAC_REC");
            entity.Property(e => e.LsFecRec)
                .HasColumnType("datetime")
                .HasColumnName("LS_FEC_REC");
            entity.Property(e => e.LsFinan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LS_FINAN");
            entity.Property(e => e.LsGuarder)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_GUARDER");
            entity.Property(e => e.LsImssOb)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_IMSS_OB");
            entity.Property(e => e.LsImssPa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_IMSS_PA");
            entity.Property(e => e.LsInfAcr)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_INF_ACR");
            entity.Property(e => e.LsInfAmo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_INF_AMO");
            entity.Property(e => e.LsInfNac)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_INF_NAC");
            entity.Property(e => e.LsInfNum).HasColumnName("LS_INF_NUM");
            entity.Property(e => e.LsInvVid)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_INV_VID");
            entity.Property(e => e.LsNumBim).HasColumnName("LS_NUM_BIM");
            entity.Property(e => e.LsNumTra).HasColumnName("LS_NUM_TRA");
            entity.Property(e => e.LsParcial)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_PARCIAL");
            entity.Property(e => e.LsRecAmo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_REC_AMO");
            entity.Property(e => e.LsRecApo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_REC_APO");
            entity.Property(e => e.LsRecIms)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_REC_IMS");
            entity.Property(e => e.LsRecInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_REC_INF");
            entity.Property(e => e.LsRecRet)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_REC_RET");
            entity.Property(e => e.LsRetiro)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_RETIRO");
            entity.Property(e => e.LsRiesgos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_RIESGOS");
            entity.Property(e => e.LsStatus).HasColumnName("LS_STATUS");
            entity.Property(e => e.LsSubIms)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_SUB_IMS");
            entity.Property(e => e.LsSubInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_SUB_INF");
            entity.Property(e => e.LsSubRet)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_SUB_RET");
            entity.Property(e => e.LsTotIms)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_TOT_IMS");
            entity.Property(e => e.LsTotInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_TOT_INF");
            entity.Property(e => e.LsTotMes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_TOT_MES");
            entity.Property(e => e.LsTotRet)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LS_TOT_RET");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<LiqMov>(entity =>
        {
            entity.HasKey(e => new { e.LsPatron, e.LsYear, e.LsMonth, e.LsTipo, e.CbCodigo, e.LmTipo, e.LmFecha, e.LmClave });

            entity.ToTable("LIQ_MOV");

            entity.Property(e => e.LsPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LS_PATRON");
            entity.Property(e => e.LsYear).HasColumnName("LS_YEAR");
            entity.Property(e => e.LsMonth).HasColumnName("LS_MONTH");
            entity.Property(e => e.LsTipo).HasColumnName("LS_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.LmTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LM_TIPO");
            entity.Property(e => e.LmFecha)
                .HasColumnType("datetime")
                .HasColumnName("LM_FECHA");
            entity.Property(e => e.LmClave)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LM_CLAVE");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.LmAusenci).HasColumnName("LM_AUSENCI");
            entity.Property(e => e.LmBase)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_BASE");
            entity.Property(e => e.LmCesVej)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_CES_VEJ");
            entity.Property(e => e.LmCesvejp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_CESVEJP");
            entity.Property(e => e.LmDias).HasColumnName("LM_DIAS");
            entity.Property(e => e.LmEymDin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYM_DIN");
            entity.Property(e => e.LmEymEsp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYM_ESP");
            entity.Property(e => e.LmEymExc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYM_EXC");
            entity.Property(e => e.LmEymFij)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYM_FIJ");
            entity.Property(e => e.LmEymdinp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYMDINP");
            entity.Property(e => e.LmEymespp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYMESPP");
            entity.Property(e => e.LmEymexcp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_EYMEXCP");
            entity.Property(e => e.LmGuarder)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_GUARDER");
            entity.Property(e => e.LmIncapac).HasColumnName("LM_INCAPAC");
            entity.Property(e => e.LmInfAmo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_INF_AMO");
            entity.Property(e => e.LmInfPat)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_INF_PAT");
            entity.Property(e => e.LmInvVid)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_INV_VID");
            entity.Property(e => e.LmInvvidp)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_INVVIDP");
            entity.Property(e => e.LmKarFec)
                .HasColumnType("datetime")
                .HasColumnName("LM_KAR_FEC");
            entity.Property(e => e.LmKarTip)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LM_KAR_TIP");
            entity.Property(e => e.LmRetiro)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_RETIRO");
            entity.Property(e => e.LmRiesgos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LM_RIESGOS");

            entity.HasOne(d => d.LiqEmp).WithMany(p => p.LiqMovs)
                .HasForeignKey(d => new { d.LsPatron, d.LsYear, d.LsMonth, d.LsTipo, d.CbCodigo })
                .HasConstraintName("FK_Liq_Mov_Liq_Emp");
        });

        modelBuilder.Entity<Maestro>(entity =>
        {
            entity.HasKey(e => e.MaCodigo);

            entity.ToTable("MAESTRO", tb => tb.HasTrigger("TU_MAESTRO"));

            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MaActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_ACTIVO");
            entity.Property(e => e.MaCedula)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_CEDULA");
            entity.Property(e => e.MaCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_CIUDAD");
            entity.Property(e => e.MaDirecci)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_DIRECCI");
            entity.Property(e => e.MaEmpresa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_EMPRESA");
            entity.Property(e => e.MaImagen)
                .HasColumnType("image")
                .HasColumnName("MA_IMAGEN");
            entity.Property(e => e.MaNagente)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_NAGENTE");
            entity.Property(e => e.MaNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MA_NOMBRE");
            entity.Property(e => e.MaNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MA_NUMERO");
            entity.Property(e => e.MaRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_RFC");
            entity.Property(e => e.MaTagente).HasColumnName("MA_TAGENTE");
            entity.Property(e => e.MaTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_TEL");
            entity.Property(e => e.MaTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MA_TEXTO");
            entity.Property(e => e.PcCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_CODIGO");
        });

        modelBuilder.Entity<MedEntr>(entity =>
        {
            entity.HasKey(e => new { e.MeCodigo, e.MtFecha, e.ExCodigo });

            entity.ToTable("MED_ENTR");

            entity.Property(e => e.MeCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ME_CODIGO");
            entity.Property(e => e.MtFecha)
                .HasColumnType("datetime")
                .HasColumnName("MT_FECHA");
            entity.Property(e => e.ExCodigo).HasColumnName("EX_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MtCantida)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MT_CANTIDA");
            entity.Property(e => e.MtComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MT_COMENTA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.ExCodigoNavigation).WithMany(p => p.MedEntrs)
                .HasForeignKey(d => d.ExCodigo)
                .HasConstraintName("FK_MED_ENTR_EXPEDIEN");

            entity.HasOne(d => d.MeCodigoNavigation).WithMany(p => p.MedEntrs)
                .HasForeignKey(d => d.MeCodigo)
                .HasConstraintName("FK_MED_ENTR_MEDICINA");
        });

        modelBuilder.Entity<Medicina>(entity =>
        {
            entity.HasKey(e => e.MeCodigo);

            entity.ToTable("MEDICINA");

            entity.Property(e => e.MeCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ME_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MeDescrip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ME_DESCRIP");
            entity.Property(e => e.MeIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_INGLES");
            entity.Property(e => e.MeMedida)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ME_MEDIDA");
            entity.Property(e => e.MeNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_NOMBRE");
            entity.Property(e => e.MeNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("ME_NUMERO");
            entity.Property(e => e.MeTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ME_TEXTO");
            entity.Property(e => e.MeTipo).HasColumnName("ME_TIPO");
        });

        modelBuilder.Entity<Misrepor>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.ReCodigo });

            entity.ToTable("MISREPOR");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.ReCodigo).HasColumnName("RE_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.ReCodigoNavigation).WithMany(p => p.Misrepors)
                .HasForeignKey(d => d.ReCodigo)
                .HasConstraintName("FK_MISREPOR_REPORTE");
        });

        modelBuilder.Entity<Modula1>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MODULA1");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Modula2>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MODULA2");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Modula3>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MODULA3");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MONEDA");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbValor)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_VALOR");
        });

        modelBuilder.Entity<MotAuto>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MOT_AUTO", tb => tb.HasTrigger("TU_MOT_AUTO"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<MotBaja>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MOT_BAJA", tb => tb.HasTrigger("TU_MOT_BAJA"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbImss).HasColumnName("TB_IMSS");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<MotBajaIdse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MOT_BAJA_IDSE");

            entity.Property(e => e.CodigoIdse)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODIGO_IDSE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("DESCRIPCION");
        });

        modelBuilder.Entity<MotCheca>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MOT_CHECA");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<MotTool>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MOT_TOOL", tb =>
                {
                    tb.HasTrigger("TD_MOT_TOOL");
                    tb.HasTrigger("TU_MOT_TOOL");
                });

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbPresta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_PRESTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Motacci>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MOTACCI", tb => tb.HasTrigger("TU_MOTACCI"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Motscrap>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MOTSCRAP");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<MovGral>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero, e.CoNumero });

            entity.ToTable("MOV_GRAL");

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MgFijo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MG_FIJO");
            entity.Property(e => e.MgMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MG_MONTO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CoNumeroNavigation).WithMany(p => p.MovGrals)
                .HasForeignKey(d => d.CoNumero)
                .HasConstraintName("FK_Mov_Gral_Concepto");

            entity.HasOne(d => d.Periodo).WithMany(p => p.MovGrals)
                .HasForeignKey(d => new { d.PeYear, d.PeTipo, d.PeNumero })
                .HasConstraintName("FK_Mov_Gral_Periodo");
        });

        modelBuilder.Entity<Movimien>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero, e.CbCodigo, e.CoNumero, e.MoReferen });

            entity.ToTable("MOVIMIEN");

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.MoReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("MO_REFEREN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MoActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MO_ACTIVO");
            entity.Property(e => e.MoDeducci)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MO_DEDUCCI");
            entity.Property(e => e.MoImpCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MO_IMP_CAL");
            entity.Property(e => e.MoPerCal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MO_PER_CAL");
            entity.Property(e => e.MoPercepc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MO_PERCEPC");
            entity.Property(e => e.MoXIspt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MO_X_ISPT");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CoNumeroNavigation).WithMany(p => p.Movimiens)
                .HasForeignKey(d => d.CoNumero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movimien_Concepto");

            entity.HasOne(d => d.Nomina).WithMany(p => p.Movimiens)
                .HasForeignKey(d => new { d.PeYear, d.PeTipo, d.PeNumero, d.CbCodigo })
                .HasConstraintName("FK_Movimien_Nomina");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("MUNICIPIO");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbEntidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ENTIDAD");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbStps).HasColumnName("TB_STPS");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<NavDato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NAV_DATOS");

            entity.Property(e => e.NavAnio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_ANIO");
            entity.Property(e => e.NavDesctnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_DESCTNOM");
            entity.Property(e => e.NavEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAV_EMPRESA");
            entity.Property(e => e.NavIdsesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_IDSESION");
            entity.Property(e => e.NavNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_NOMBRE");
            entity.Property(e => e.NavNomina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_NOMINA");
            entity.Property(e => e.NavNumnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_NUMNOM");
            entity.Property(e => e.NavTexto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAV_TEXTO");
            entity.Property(e => e.NavTnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_TNOM");
            entity.Property(e => e.NavUsersesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_USERSESION");
        });

        modelBuilder.Entity<NavimssDato>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NAVIMSS_DATOS");

            entity.Property(e => e.NavimssAnio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_ANIO");
            entity.Property(e => e.NavimssIdsesion).HasColumnName("NAVIMSS_IDSESION");
            entity.Property(e => e.NavimssMes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_MES");
            entity.Property(e => e.NavimssRegpat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_REGPAT");
            entity.Property(e => e.NavimssTipo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_TIPO");
            entity.Property(e => e.NavimssUsersesion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_USERSESION");
        });

        modelBuilder.Entity<NavimssDatosbn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NAVIMSS_DATOSBN");

            entity.Property(e => e.NavimssAnio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_ANIO");
            entity.Property(e => e.NavimssIdpat)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_IDPAT");
            entity.Property(e => e.NavimssIdsesion).HasColumnName("NAVIMSS_IDSESION");
            entity.Property(e => e.NavimssMes)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_MES");
            entity.Property(e => e.NavimssRegpat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_REGPAT");
            entity.Property(e => e.NavimssTipo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_TIPO");
            entity.Property(e => e.NavimssUsersesion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_USERSESION");
        });

        modelBuilder.Entity<NivDime>(entity =>
        {
            entity.HasKey(e => new { e.DmCodigo, e.NpCodigo });

            entity.ToTable("NIV_DIME");

            entity.Property(e => e.DmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DM_CODIGO");
            entity.Property(e => e.NpCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NP_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.NdDescrip)
                .HasColumnType("text")
                .HasColumnName("ND_DESCRIP");
            entity.Property(e => e.NdResumen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ND_RESUMEN");

            entity.HasOne(d => d.DmCodigoNavigation).WithMany(p => p.NivDimes)
                .HasForeignKey(d => d.DmCodigo)
                .HasConstraintName("FK_NIV_DIME_DIMENSIO");

            entity.HasOne(d => d.NpCodigoNavigation).WithMany(p => p.NivDimes)
                .HasForeignKey(d => d.NpCodigo)
                .HasConstraintName("FK_NIV_DIME_NIV_PTO");
        });

        modelBuilder.Entity<NivPto>(entity =>
        {
            entity.HasKey(e => e.NpCodigo);

            entity.ToTable("NIV_PTO", tb => tb.HasTrigger("TU_NIV_PTO"));

            entity.Property(e => e.NpCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NP_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.NpActitud)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NP_ACTITUD");
            entity.Property(e => e.NpDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NP_DESCRIP");
            entity.Property(e => e.NpDetalle)
                .HasColumnType("text")
                .HasColumnName("NP_DETALLE");
            entity.Property(e => e.NpIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NP_INGLES");
            entity.Property(e => e.NpNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NP_NUMERO");
            entity.Property(e => e.NpTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NP_TEXTO");
        });

        modelBuilder.Entity<Nivel1>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL1", tb => tb.HasTrigger("TU_NIVEL1"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel2>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL2", tb => tb.HasTrigger("TU_NIVEL2"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel3>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL3", tb => tb.HasTrigger("TU_NIVEL3"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel4>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL4", tb => tb.HasTrigger("TU_NIVEL4"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel5>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL5", tb => tb.HasTrigger("TU_NIVEL5"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel6>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL6", tb => tb.HasTrigger("TU_NIVEL6"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel7>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL7", tb => tb.HasTrigger("TU_NIVEL7"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel8>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL8", tb => tb.HasTrigger("TU_NIVEL8"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nivel9>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("NIVEL9", tb => tb.HasTrigger("TU_NIVEL9"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_SUB_CTA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Nomina>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero, e.CbCodigo }).IsClustered(false);

            entity.ToTable("NOMINA");

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbBanEle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_BAN_ELE");
            entity.Property(e => e.CbClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CLASIFI");
            entity.Property(e => e.CbCtaGas)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CTA_GAS");
            entity.Property(e => e.CbCtaVal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_CTA_VAL");
            entity.Property(e => e.CbNivel0)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL0");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.CbPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PATRON");
            entity.Property(e => e.CbPlaza).HasColumnName("CB_PLAZA");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.CbSalInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SAL_INT");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.CbZonaGe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ZONA_GE");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.NoAdicion)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_ADICION");
            entity.Property(e => e.NoAproba).HasColumnName("NO_APROBA");
            entity.Property(e => e.NoAsiFin)
                .HasColumnType("datetime")
                .HasColumnName("NO_ASI_FIN");
            entity.Property(e => e.NoAsiIni)
                .HasColumnType("datetime")
                .HasColumnName("NO_ASI_INI");
            entity.Property(e => e.NoDTurno).HasColumnName("NO_D_TURNO");
            entity.Property(e => e.NoDeducci)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DEDUCCI");
            entity.Property(e => e.NoDesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DES_TRA");
            entity.Property(e => e.NoDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS");
            entity.Property(e => e.NoDiasAg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_AG");
            entity.Property(e => e.NoDiasAj).HasColumnName("NO_DIAS_AJ");
            entity.Property(e => e.NoDiasAs).HasColumnName("NO_DIAS_AS");
            entity.Property(e => e.NoDiasBa)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("NO_DIAS_BA");
            entity.Property(e => e.NoDiasCg).HasColumnName("NO_DIAS_CG");
            entity.Property(e => e.NoDiasEm).HasColumnName("NO_DIAS_EM");
            entity.Property(e => e.NoDiasFi).HasColumnName("NO_DIAS_FI");
            entity.Property(e => e.NoDiasFj).HasColumnName("NO_DIAS_FJ");
            entity.Property(e => e.NoDiasFv).HasColumnName("NO_DIAS_FV");
            entity.Property(e => e.NoDiasIn).HasColumnName("NO_DIAS_IN");
            entity.Property(e => e.NoDiasNt).HasColumnName("NO_DIAS_NT");
            entity.Property(e => e.NoDiasOt).HasColumnName("NO_DIAS_OT");
            entity.Property(e => e.NoDiasPe).HasColumnName("NO_DIAS_PE");
            entity.Property(e => e.NoDiasPv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_PV");
            entity.Property(e => e.NoDiasRe).HasColumnName("NO_DIAS_RE");
            entity.Property(e => e.NoDiasSg).HasColumnName("NO_DIAS_SG");
            entity.Property(e => e.NoDiasSi)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_SI");
            entity.Property(e => e.NoDiasSs).HasColumnName("NO_DIAS_SS");
            entity.Property(e => e.NoDiasSu).HasColumnName("NO_DIAS_SU");
            entity.Property(e => e.NoDiasVa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_VA");
            entity.Property(e => e.NoDiasVj)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_VJ");
            entity.Property(e => e.NoDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DOBLES");
            entity.Property(e => e.NoExentas)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_EXENTAS");
            entity.Property(e => e.NoExtras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_EXTRAS");
            entity.Property(e => e.NoFecLiq)
                .HasColumnType("datetime")
                .HasColumnName("NO_FEC_LIQ");
            entity.Property(e => e.NoFecOk)
                .HasColumnType("datetime")
                .HasColumnName("NO_FEC_OK");
            entity.Property(e => e.NoFecPag)
                .HasColumnType("datetime")
                .HasColumnName("NO_FEC_PAG");
            entity.Property(e => e.NoFesPag)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_FES_PAG");
            entity.Property(e => e.NoFesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_FES_TRA");
            entity.Property(e => e.NoFolio1).HasColumnName("NO_FOLIO_1");
            entity.Property(e => e.NoFolio2).HasColumnName("NO_FOLIO_2");
            entity.Property(e => e.NoFolio3).HasColumnName("NO_FOLIO_3");
            entity.Property(e => e.NoFolio4).HasColumnName("NO_FOLIO_4");
            entity.Property(e => e.NoFolio5).HasColumnName("NO_FOLIO_5");
            entity.Property(e => e.NoFuera)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NO_FUERA");
            entity.Property(e => e.NoGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NO_GLOBAL");
            entity.Property(e => e.NoHorOk)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NO_HOR_OK");
            entity.Property(e => e.NoHoraCg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORA_CG");
            entity.Property(e => e.NoHoraPd)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORA_PD");
            entity.Property(e => e.NoHoraSg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORA_SG");
            entity.Property(e => e.NoHorapdt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORAPDT");
            entity.Property(e => e.NoHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORAS");
            entity.Property(e => e.NoHorasnt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORASNT");
            entity.Property(e => e.NoImpCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_IMP_CAL");
            entity.Property(e => e.NoJornada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_JORNADA");
            entity.Property(e => e.NoLiquida).HasColumnName("NO_LIQUIDA");
            entity.Property(e => e.NoNeto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_NETO");
            entity.Property(e => e.NoObserva)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NO_OBSERVA");
            entity.Property(e => e.NoPerCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PER_CAL");
            entity.Property(e => e.NoPerMen)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PER_MEN");
            entity.Property(e => e.NoPercepc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PERCEPC");
            entity.Property(e => e.NoPreExt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PRE_EXT");
            entity.Property(e => e.NoPrevGr)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PREV_GR");
            entity.Property(e => e.NoRastreo)
                .HasColumnType("text")
                .HasColumnName("NO_RASTREO");
            entity.Property(e => e.NoStatus).HasColumnName("NO_STATUS");
            entity.Property(e => e.NoSupOk).HasColumnName("NO_SUP_OK");
            entity.Property(e => e.NoTardes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_TARDES");
            entity.Property(e => e.NoTotPre)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_TOT_PRE");
            entity.Property(e => e.NoTriples)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_TRIPLES");
            entity.Property(e => e.NoUserRj).HasColumnName("NO_USER_RJ");
            entity.Property(e => e.NoUsrPag).HasColumnName("NO_USR_PAG");
            entity.Property(e => e.NoVacTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_VAC_TRA");
            entity.Property(e => e.NoXCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_X_CAL");
            entity.Property(e => e.NoXIspt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_X_ISPT");
            entity.Property(e => e.NoXMens)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_X_MENS");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.Periodo).WithMany(p => p.Nominas)
                .HasForeignKey(d => new { d.PeYear, d.PeTipo, d.PeNumero })
                .HasConstraintName("FK_Nomina_Periodo");
        });

        modelBuilder.Entity<Nomparam>(entity =>
        {
            entity.HasKey(e => e.NpFolio);

            entity.ToTable("NOMPARAM");

            entity.Property(e => e.NpFolio)
                .ValueGeneratedNever()
                .HasColumnName("NP_FOLIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.NpActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NP_ACTIVO");
            entity.Property(e => e.NpDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NP_DESCRIP");
            entity.Property(e => e.NpFormula)
                .HasColumnType("text")
                .HasColumnName("NP_FORMULA");
            entity.Property(e => e.NpNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NP_NOMBRE");
            entity.Property(e => e.NpTipo).HasColumnName("NP_TIPO");
        });

        modelBuilder.Entity<Numerica>(entity =>
        {
            entity.HasKey(e => e.NuCodigo);

            entity.ToTable("NUMERICA");

            entity.Property(e => e.NuCodigo)
                .ValueGeneratedNever()
                .HasColumnName("NU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.NuDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NU_DESCRIP");
            entity.Property(e => e.NuIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NU_INGLES");
            entity.Property(e => e.NuNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NU_NUMERO");
            entity.Property(e => e.NuTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NU_TEXTO");
        });

        modelBuilder.Entity<OcupaNac>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("OCUPA_NAC");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Opera>(entity =>
        {
            entity.HasKey(e => e.OpNumber);

            entity.ToTable("OPERA", tb => tb.HasTrigger("TU_OPERA"));

            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.CbNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL1");
            entity.Property(e => e.CbNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL2");
            entity.Property(e => e.CbNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL3");
            entity.Property(e => e.CbNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL4");
            entity.Property(e => e.CbNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL5");
            entity.Property(e => e.CbNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL6");
            entity.Property(e => e.CbNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL7");
            entity.Property(e => e.CbNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL8");
            entity.Property(e => e.CbNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL9");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OP_DESCRIP");
            entity.Property(e => e.OpFactor)
                .HasColumnType("numeric(15, 6)")
                .HasColumnName("OP_FACTOR");
            entity.Property(e => e.OpIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OP_INGLES");
            entity.Property(e => e.OpNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OP_NOMBRE");
            entity.Property(e => e.OpStdCst)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("OP_STD_CST");
            entity.Property(e => e.OpStdHr)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("OP_STD_HR");
            entity.Property(e => e.OpTipo).HasColumnName("OP_TIPO");
            entity.Property(e => e.ToCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TO_CODIGO");
        });

        modelBuilder.Entity<Ordfolio>(entity =>
        {
            entity.HasKey(e => new { e.FlCodigo, e.OfPosicio });

            entity.ToTable("ORDFOLIO");

            entity.Property(e => e.FlCodigo).HasColumnName("FL_CODIGO");
            entity.Property(e => e.OfPosicio).HasColumnName("OF_POSICIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OfCampo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OF_CAMPO");
            entity.Property(e => e.OfDescend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("OF_DESCEND");
            entity.Property(e => e.OfTitulo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OF_TITULO");

            entity.HasOne(d => d.FlCodigoNavigation).WithMany(p => p.Ordfolios)
                .HasForeignKey(d => d.FlCodigo)
                .HasConstraintName("FK_OrdFolio_Folio");
        });

        modelBuilder.Entity<Otrasper>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("OTRASPER", tb => tb.HasTrigger("TU_OTRASPER"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbImss).HasColumnName("TB_IMSS");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbIspt).HasColumnName("TB_ISPT");
            entity.Property(e => e.TbMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_MONTO");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTasa)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
            entity.Property(e => e.TbTope)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_TOPE");
        });

        modelBuilder.Entity<Pariente>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.PaRelacio, e.PaFolio });

            entity.ToTable("PARIENTE");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PaRelacio).HasColumnName("PA_RELACIO");
            entity.Property(e => e.PaFolio).HasColumnName("PA_FOLIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PaFecNac)
                .HasColumnType("datetime")
                .HasColumnName("PA_FEC_NAC");
            entity.Property(e => e.PaNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PA_NOMBRE");
            entity.Property(e => e.PaNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PA_NUMERO");
            entity.Property(e => e.PaSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PA_SEXO");
            entity.Property(e => e.PaTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PA_TEXTO");
            entity.Property(e => e.PaTrabaja).HasColumnName("PA_TRABAJA");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Parientes)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Pariente_Colabora");
        });

        modelBuilder.Entity<Parte>(entity =>
        {
            entity.HasKey(e => e.ArCodigo);

            entity.ToTable("PARTES", tb => tb.HasTrigger("TU_PARTES"));

            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.ArBarcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AR_BARCODE");
            entity.Property(e => e.ArFactor)
                .HasColumnType("numeric(15, 6)")
                .HasColumnName("AR_FACTOR");
            entity.Property(e => e.ArIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AR_INGLES");
            entity.Property(e => e.ArNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("AR_NOMBRE");
            entity.Property(e => e.ArShort)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AR_SHORT");
            entity.Property(e => e.ArStdCst)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AR_STD_CST");
            entity.Property(e => e.ArStdHr)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("AR_STD_HR");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TT_CODIGO");
        });

        modelBuilder.Entity<PcarAbo>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.PrTipo, e.PrReferen, e.CrFecha });

            entity.ToTable("PCAR_ABO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");
            entity.Property(e => e.PrReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PR_REFEREN");
            entity.Property(e => e.CrFecha)
                .HasColumnType("datetime")
                .HasColumnName("CR_FECHA");
            entity.Property(e => e.CrAbono)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CR_ABONO");
            entity.Property(e => e.CrCaptura)
                .HasColumnType("datetime")
                .HasColumnName("CR_CAPTURA");
            entity.Property(e => e.CrCargo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CR_CARGO");
            entity.Property(e => e.CrObserva)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CR_OBSERVA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.Prestamo).WithMany(p => p.PcarAbos)
                .HasForeignKey(d => new { d.CbCodigo, d.PrTipo, d.PrReferen })
                .HasConstraintName("FK_PCar_Abo_Prestamo");
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.HasKey(e => e.PuCodigo);

            entity.ToTable("PERFIL");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PfContrl1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PF_CONTRL1");
            entity.Property(e => e.PfContrl2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PF_CONTRL2");
            entity.Property(e => e.PfDescrip)
                .HasColumnType("text")
                .HasColumnName("PF_DESCRIP");
            entity.Property(e => e.PfEdadmax).HasColumnName("PF_EDADMAX");
            entity.Property(e => e.PfEdadmin).HasColumnName("PF_EDADMIN");
            entity.Property(e => e.PfEstudio).HasColumnName("PF_ESTUDIO");
            entity.Property(e => e.PfExpPto).HasColumnName("PF_EXP_PTO");
            entity.Property(e => e.PfFecha)
                .HasColumnType("datetime")
                .HasColumnName("PF_FECHA");
            entity.Property(e => e.PfNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PF_NUMERO1");
            entity.Property(e => e.PfNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PF_NUMERO2");
            entity.Property(e => e.PfObjetiv)
                .HasColumnType("text")
                .HasColumnName("PF_OBJETIV");
            entity.Property(e => e.PfPosting)
                .HasColumnType("text")
                .HasColumnName("PF_POSTING");
            entity.Property(e => e.PfSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PF_SEXO");
            entity.Property(e => e.PfTexto1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PF_TEXTO1");
            entity.Property(e => e.PfTexto2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PF_TEXTO2");

            entity.HasOne(d => d.PuCodigoNavigation).WithOne(p => p.Perfil)
                .HasForeignKey<Perfil>(d => d.PuCodigo)
                .HasConstraintName("FK_PERFIL_PUESTO");
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero });

            entity.ToTable("PERIODO");

            entity.HasIndex(e => new { e.PeYear, e.PeTipo, e.PeMes, e.PeNumero }, "XAK1PERIODO").IsUnique();

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PeAhorro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PE_AHORRO");
            entity.Property(e => e.PeAsiFin)
                .HasColumnType("datetime")
                .HasColumnName("PE_ASI_FIN");
            entity.Property(e => e.PeAsiIni)
                .HasColumnType("datetime")
                .HasColumnName("PE_ASI_INI");
            entity.Property(e => e.PeCal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PE_CAL");
            entity.Property(e => e.PeCandado).HasColumnName("PE_CANDADO");
            entity.Property(e => e.PeDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PE_DESCRIP");
            entity.Property(e => e.PeDiaMes).HasColumnName("PE_DIA_MES");
            entity.Property(e => e.PeDias).HasColumnName("PE_DIAS");
            entity.Property(e => e.PeDiasAc).HasColumnName("PE_DIAS_AC");
            entity.Property(e => e.PeFecFin)
                .HasColumnType("datetime")
                .HasColumnName("PE_FEC_FIN");
            entity.Property(e => e.PeFecIni)
                .HasColumnType("datetime")
                .HasColumnName("PE_FEC_INI");
            entity.Property(e => e.PeFecMod)
                .HasColumnType("datetime")
                .HasColumnName("PE_FEC_MOD");
            entity.Property(e => e.PeFecPag)
                .HasColumnType("datetime")
                .HasColumnName("PE_FEC_PAG");
            entity.Property(e => e.PeIncBaj)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PE_INC_BAJ");
            entity.Property(e => e.PeLog)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PE_LOG");
            entity.Property(e => e.PeMes).HasColumnName("PE_MES");
            entity.Property(e => e.PeNumEmp).HasColumnName("PE_NUM_EMP");
            entity.Property(e => e.PePerMes).HasColumnName("PE_PER_MES");
            entity.Property(e => e.PePerTot).HasColumnName("PE_PER_TOT");
            entity.Property(e => e.PePosMes).HasColumnName("PE_POS_MES");
            entity.Property(e => e.PePrestam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PE_PRESTAM");
            entity.Property(e => e.PeSoloEx)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PE_SOLO_EX");
            entity.Property(e => e.PeStatus).HasColumnName("PE_STATUS");
            entity.Property(e => e.PeTotDed)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PE_TOT_DED");
            entity.Property(e => e.PeTotNet)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PE_TOT_NET");
            entity.Property(e => e.PeTotPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PE_TOT_PER");
            entity.Property(e => e.PeUso).HasColumnName("PE_USO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.PmFecIni });

            entity.ToTable("PERMISO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PmFecIni)
                .HasColumnType("datetime")
                .HasColumnName("PM_FEC_INI");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PmCaptura)
                .HasColumnType("datetime")
                .HasColumnName("PM_CAPTURA");
            entity.Property(e => e.PmClasifi).HasColumnName("PM_CLASIFI");
            entity.Property(e => e.PmComenta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PM_COMENTA");
            entity.Property(e => e.PmDias).HasColumnName("PM_DIAS");
            entity.Property(e => e.PmFecFin)
                .HasColumnType("datetime")
                .HasColumnName("PM_FEC_FIN");
            entity.Property(e => e.PmGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PM_GLOBAL");
            entity.Property(e => e.PmNumero)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PM_NUMERO");
            entity.Property(e => e.PmTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PM_TIPO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Permiso_Colabora");
        });

        modelBuilder.Entity<Plaza>(entity =>
        {
            entity.HasKey(e => e.PlFolio);

            entity.ToTable("PLAZA", tb => tb.HasTrigger("TU_PLAZA"));

            entity.HasIndex(e => new { e.PuCodigo, e.PlOrden }, "XAK1PLAZA").IsUnique();

            entity.Property(e => e.PlFolio).HasColumnName("PL_FOLIO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PlArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_AREA");
            entity.Property(e => e.PlAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_AUTOSAL");
            entity.Property(e => e.PlCheca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_CHECA");
            entity.Property(e => e.PlClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_CLASIFI");
            entity.Property(e => e.PlCodigo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PL_CODIGO");
            entity.Property(e => e.PlContrat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_CONTRAT");
            entity.Property(e => e.PlFecFin)
                .HasColumnType("datetime")
                .HasColumnName("PL_FEC_FIN");
            entity.Property(e => e.PlFecIni)
                .HasColumnType("datetime")
                .HasColumnName("PL_FEC_INI");
            entity.Property(e => e.PlIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PL_INGLES");
            entity.Property(e => e.PlNivel0)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL0");
            entity.Property(e => e.PlNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL1");
            entity.Property(e => e.PlNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL2");
            entity.Property(e => e.PlNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL3");
            entity.Property(e => e.PlNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL4");
            entity.Property(e => e.PlNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL5");
            entity.Property(e => e.PlNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL6");
            entity.Property(e => e.PlNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL7");
            entity.Property(e => e.PlNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL8");
            entity.Property(e => e.PlNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_NIVEL9");
            entity.Property(e => e.PlNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PL_NOMBRE");
            entity.Property(e => e.PlNomina).HasColumnName("PL_NOMINA");
            entity.Property(e => e.PlNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PL_NUMERO");
            entity.Property(e => e.PlOrden).HasColumnName("PL_ORDEN");
            entity.Property(e => e.PlPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_PATRON");
            entity.Property(e => e.PlPerVar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PL_PER_VAR");
            entity.Property(e => e.PlReporta).HasColumnName("PL_REPORTA");
            entity.Property(e => e.PlSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PL_SALARIO");
            entity.Property(e => e.PlSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PL_SUB_CTA");
            entity.Property(e => e.PlTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_TABLASS");
            entity.Property(e => e.PlTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PL_TEXTO");
            entity.Property(e => e.PlTipo).HasColumnName("PL_TIPO");
            entity.Property(e => e.PlTirep).HasColumnName("PL_TIREP");
            entity.Property(e => e.PlTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_TURNO");
            entity.Property(e => e.PlZonaGe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PL_ZONA_GE");
            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.Plazas)
                .HasForeignKey(d => d.PuCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PLAZA_PUESTO");
        });

        modelBuilder.Entity<PolHead>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero, e.PtCodigo });

            entity.ToTable("POL_HEAD");

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PT_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PhFecha)
                .HasColumnType("datetime")
                .HasColumnName("PH_FECHA");
            entity.Property(e => e.PhHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PH_HORA");
            entity.Property(e => e.PhReporte).HasColumnName("PH_REPORTE");
            entity.Property(e => e.PhStatus).HasColumnName("PH_STATUS");
            entity.Property(e => e.PhVeces).HasColumnName("PH_VECES");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.PtCodigoNavigation).WithMany(p => p.PolHeads)
                .HasForeignKey(d => d.PtCodigo)
                .HasConstraintName("FK_POL_HEAD_POL_TIPO");

            entity.HasOne(d => d.Periodo).WithMany(p => p.PolHeads)
                .HasForeignKey(d => new { d.PeYear, d.PeTipo, d.PeNumero })
                .HasConstraintName("FK_POL_HEAD_PERIODO");
        });

        modelBuilder.Entity<PolTipo>(entity =>
        {
            entity.HasKey(e => e.PtCodigo);

            entity.ToTable("POL_TIPO");

            entity.Property(e => e.PtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PT_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PtIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PT_INGLES");
            entity.Property(e => e.PtNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PT_NOMBRE");
            entity.Property(e => e.PtNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PT_NUMERO");
            entity.Property(e => e.PtReporte).HasColumnName("PT_REPORTE");
            entity.Property(e => e.PtTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PT_TEXTO");
        });

        modelBuilder.Entity<Poliza>(entity =>
        {
            entity.HasKey(e => new { e.PeYear, e.PeTipo, e.PeNumero, e.PtCodigo, e.TpFolio });

            entity.ToTable("POLIZA");

            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PT_CODIGO");
            entity.Property(e => e.TpFolio).HasColumnName("TP_FOLIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TpAbono)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_ABONO");
            entity.Property(e => e.TpCarAbo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_CAR_ABO");
            entity.Property(e => e.TpCargo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_CARGO");
            entity.Property(e => e.TpComenta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TP_COMENTA");
            entity.Property(e => e.TpCuenta)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TP_CUENTA");
            entity.Property(e => e.TpNumero).HasColumnName("TP_NUMERO");
            entity.Property(e => e.TpTexto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TP_TEXTO");

            entity.HasOne(d => d.PolHead).WithMany(p => p.Polizas)
                .HasForeignKey(d => new { d.PeYear, d.PeTipo, d.PeNumero, d.PtCodigo })
                .HasConstraintName("FK_POLIZA_POL_HEAD");
        });

        modelBuilder.Entity<Prestaci>(entity =>
        {
            entity.HasKey(e => new { e.TbCodigo, e.PtYear });

            entity.ToTable("PRESTACI");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.PtYear).HasColumnName("PT_YEAR");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PtDiasAd)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PT_DIAS_AD");
            entity.Property(e => e.PtDiasAg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PT_DIAS_AG");
            entity.Property(e => e.PtDiasVa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PT_DIAS_VA");
            entity.Property(e => e.PtFactor)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("PT_FACTOR");
            entity.Property(e => e.PtPago7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PT_PAGO_7");
            entity.Property(e => e.PtPrima7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PT_PRIMA_7");
            entity.Property(e => e.PtPrimado)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("PT_PRIMADO");
            entity.Property(e => e.PtPrimava)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("PT_PRIMAVA");

            entity.HasOne(d => d.TbCodigoNavigation).WithMany(p => p.Prestacis)
                .HasForeignKey(d => d.TbCodigo)
                .HasConstraintName("FK_Prestaci_SSocial");
        });

        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.PrTipo, e.PrReferen });

            entity.ToTable("PRESTAMO", tb => tb.HasTrigger("TU_PRESTAMO"));

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PrTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PR_TIPO");
            entity.Property(e => e.PrReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PR_REFEREN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PrAbonos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_ABONOS");
            entity.Property(e => e.PrCargos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_CARGOS");
            entity.Property(e => e.PrFecha)
                .HasColumnType("datetime")
                .HasColumnName("PR_FECHA");
            entity.Property(e => e.PrFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PR_FORMULA");
            entity.Property(e => e.PrInteres)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_INTERES");
            entity.Property(e => e.PrMeses).HasColumnName("PR_MESES");
            entity.Property(e => e.PrMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_MONTO");
            entity.Property(e => e.PrMontoS)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_MONTO_S");
            entity.Property(e => e.PrNumero).HasColumnName("PR_NUMERO");
            entity.Property(e => e.PrObserva)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PR_OBSERVA");
            entity.Property(e => e.PrPagPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_PAG_PER");
            entity.Property(e => e.PrPagos).HasColumnName("PR_PAGOS");
            entity.Property(e => e.PrSaldo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_SALDO");
            entity.Property(e => e.PrSaldoI)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_SALDO_I");
            entity.Property(e => e.PrStatus).HasColumnName("PR_STATUS");
            entity.Property(e => e.PrSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PR_SUB_CTA");
            entity.Property(e => e.PrTasa)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("PR_TASA");
            entity.Property(e => e.PrTotal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PR_TOTAL");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Prestamo_Colabora");

            entity.HasOne(d => d.PrTipoNavigation).WithMany(p => p.Prestamos)
                .HasForeignKey(d => d.PrTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prestamo_TPresta");
        });

        modelBuilder.Entity<Prestaxreg>(entity =>
        {
            entity.HasKey(e => new { e.RpCodigo, e.TbCodigo });

            entity.ToTable("PRESTAXREG");

            entity.Property(e => e.RpCodigo).HasColumnName("RP_CODIGO");
            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.RpCodigoNavigation).WithMany(p => p.Prestaxregs)
                .HasForeignKey(d => d.RpCodigo)
                .HasConstraintName("FK_REGLA_REGLAPREST");
        });

        modelBuilder.Entity<Priesgo>(entity =>
        {
            entity.HasKey(e => new { e.TbCodigo, e.RtFecha });

            entity.ToTable("PRIESGO");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.RtFecha)
                .HasColumnType("datetime")
                .HasColumnName("RT_FECHA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RtD)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RT_D");
            entity.Property(e => e.RtF)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RT_F");
            entity.Property(e => e.RtI)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RT_I");
            entity.Property(e => e.RtM)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RT_M");
            entity.Property(e => e.RtN)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RT_N");
            entity.Property(e => e.RtPrima)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RT_PRIMA");
            entity.Property(e => e.RtPtant)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RT_PTANT");
            entity.Property(e => e.RtS)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RT_S");

            entity.HasOne(d => d.TbCodigoNavigation).WithMany(p => p.Priesgos)
                .HasForeignKey(d => d.TbCodigo)
                .HasConstraintName("FK_PRiesgo_RPatron");
        });

        modelBuilder.Entity<Proceso>(entity =>
        {
            entity.HasKey(e => e.PcNumero);

            entity.ToTable("PROCESO");

            entity.HasIndex(e => new { e.PcFecIni, e.PcError }, "XIE1PROCESO");

            entity.Property(e => e.PcNumero)
                .ValueGeneratedNever()
                .HasColumnName("PC_NUMERO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PcError)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_ERROR");
            entity.Property(e => e.PcFecFin)
                .HasColumnType("datetime")
                .HasColumnName("PC_FEC_FIN");
            entity.Property(e => e.PcFecIni)
                .HasColumnType("datetime")
                .HasColumnName("PC_FEC_INI");
            entity.Property(e => e.PcHorFin)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PC_HOR_FIN");
            entity.Property(e => e.PcHorIni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PC_HOR_INI");
            entity.Property(e => e.PcMaximo).HasColumnName("PC_MAXIMO");
            entity.Property(e => e.PcParams)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PC_PARAMS");
            entity.Property(e => e.PcPaso).HasColumnName("PC_PASO");
            entity.Property(e => e.PcProcId).HasColumnName("PC_PROC_ID");
            entity.Property(e => e.UsCancela).HasColumnName("US_CANCELA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<ProvCap>(entity =>
        {
            entity.HasKey(e => e.PcCodigo);

            entity.ToTable("PROV_CAP", tb => tb.HasTrigger("TU_PROV_CAP"));

            entity.Property(e => e.PcCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PcActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_ACTIVO");
            entity.Property(e => e.PcCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_CIUDAD");
            entity.Property(e => e.PcCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("PC_CODPOST");
            entity.Property(e => e.PcContact)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_CONTACT");
            entity.Property(e => e.PcDirecci)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PC_DIRECCI");
            entity.Property(e => e.PcEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PC_EMAIL");
            entity.Property(e => e.PcEstado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_ESTADO");
            entity.Property(e => e.PcFax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_FAX");
            entity.Property(e => e.PcNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PC_NOMBRE");
            entity.Property(e => e.PcNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PC_NUMERO");
            entity.Property(e => e.PcPais)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_PAIS");
            entity.Property(e => e.PcRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_RFC");
            entity.Property(e => e.PcTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_TEL");
            entity.Property(e => e.PcTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PC_TEXTO");
            entity.Property(e => e.PcWeb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PC_WEB");
        });

        modelBuilder.Entity<PtoCert>(entity =>
        {
            entity.HasKey(e => new { e.CiCodigo, e.PuCodigo });

            entity.ToTable("PTO_CERT");

            entity.Property(e => e.CiCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CI_CODIGO");
            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PcDias).HasColumnName("PC_DIAS");
            entity.Property(e => e.PcLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_LISTA");
            entity.Property(e => e.PcOpciona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PC_OPCIONA");

            entity.HasOne(d => d.CiCodigoNavigation).WithMany(p => p.PtoCerts)
                .HasForeignKey(d => d.CiCodigo)
                .HasConstraintName("FK_PTO_CERT_Certifica");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.PtoCerts)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_PTO_CERT_Puesto");
        });

        modelBuilder.Entity<PtoDime>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.DmCodigo });

            entity.ToTable("PTO_DIME");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.DmCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DM_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PdDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PD_DESCRIP");

            entity.HasOne(d => d.DmCodigoNavigation).WithMany(p => p.PtoDimes)
                .HasForeignKey(d => d.DmCodigo)
                .HasConstraintName("FK_PTO_DIME_DIMENSIO");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.PtoDimes)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_PTO_DIME_PUESTO");
        });

        modelBuilder.Entity<Ptofija>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.PfFolio });

            entity.ToTable("PTOFIJAS");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.PfFolio).HasColumnName("PF_FOLIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.PfCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PF_CODIGO");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.Ptofijas)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_PTOFIJAS_PUESTO");
        });

        modelBuilder.Entity<Ptotool>(entity =>
        {
            entity.HasKey(e => new { e.PuCodigo, e.ToCodigo });

            entity.ToTable("PTOTOOLS");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.ToCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TO_CODIGO");
            entity.Property(e => e.KtReferen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KT_REFEREN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.Ptotools)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_PTOTOOLS_PUESTO");

            entity.HasOne(d => d.ToCodigoNavigation).WithMany(p => p.Ptotools)
                .HasForeignKey(d => d.ToCodigo)
                .HasConstraintName("FK_PTOTOOLS_TOOL");
        });

        modelBuilder.Entity<Puesto>(entity =>
        {
            entity.HasKey(e => e.PuCodigo);

            entity.ToTable("PUESTO", tb =>
                {
                    tb.HasTrigger("TD_PUESTO");
                    tb.HasTrigger("TU_PUESTO");
                });

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.FpCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FP_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.NpCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NP_CODIGO");
            entity.Property(e => e.PuActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_ACTIVO");
            entity.Property(e => e.PuArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_AREA");
            entity.Property(e => e.PuAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_AUTOSAL");
            entity.Property(e => e.PuCheca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CHECA");
            entity.Property(e => e.PuClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CLASIFI");
            entity.Property(e => e.PuClave)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PU_CLAVE");
            entity.Property(e => e.PuContrat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CONTRAT");
            entity.Property(e => e.PuCosto1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_COSTO1");
            entity.Property(e => e.PuCosto2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_COSTO2");
            entity.Property(e => e.PuCosto3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_COSTO3");
            entity.Property(e => e.PuDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PU_DESCRIP");
            entity.Property(e => e.PuDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PU_DETALLE");
            entity.Property(e => e.PuIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PU_INGLES");
            entity.Property(e => e.PuLevel).HasColumnName("PU_LEVEL");
            entity.Property(e => e.PuNivel0)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL0");
            entity.Property(e => e.PuNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL1");
            entity.Property(e => e.PuNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL2");
            entity.Property(e => e.PuNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL3");
            entity.Property(e => e.PuNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL4");
            entity.Property(e => e.PuNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL5");
            entity.Property(e => e.PuNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL6");
            entity.Property(e => e.PuNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL7");
            entity.Property(e => e.PuNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL8");
            entity.Property(e => e.PuNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_NIVEL9");
            entity.Property(e => e.PuNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_NUMERO");
            entity.Property(e => e.PuPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_PATRON");
            entity.Property(e => e.PuPerVar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_PER_VAR");
            entity.Property(e => e.PuPlazas).HasColumnName("PU_PLAZAS");
            entity.Property(e => e.PuReporta)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_REPORTA");
            entity.Property(e => e.PuSalEn1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_SAL_EN1");
            entity.Property(e => e.PuSalEn2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_SAL_EN2");
            entity.Property(e => e.PuSalMax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_SAL_MAX");
            entity.Property(e => e.PuSalMed)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_SAL_MED");
            entity.Property(e => e.PuSalMin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_SAL_MIN");
            entity.Property(e => e.PuSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("PU_SALARIO");
            entity.Property(e => e.PuSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PU_SUB_CTA");
            entity.Property(e => e.PuTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_TABLASS");
            entity.Property(e => e.PuTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PU_TEXTO");
            entity.Property(e => e.PuTipo).HasColumnName("PU_TIPO");
            entity.Property(e => e.PuTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_TURNO");
            entity.Property(e => e.PuZonaGe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_ZONA_GE");
        });

        modelBuilder.Entity<Query>(entity =>
        {
            entity.HasKey(e => e.QuCodigo);

            entity.ToTable("QUERYS", tb => tb.HasTrigger("TU_QUERYS"));

            entity.Property(e => e.QuCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.QuCandado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CANDADO");
            entity.Property(e => e.QuDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("QU_DESCRIP");
            entity.Property(e => e.QuFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("QU_FILTRO");
            entity.Property(e => e.QuNavega)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_NAVEGA");
            entity.Property(e => e.QuNivel).HasColumnName("QU_NIVEL");
            entity.Property(e => e.QuOrden).HasColumnName("QU_ORDEN");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<RAtributo>(entity =>
        {
            entity.HasKey(e => new { e.EnCodigo, e.AtCampo }).HasName("PK__R_ATRIBUTO__5D60DB10");

            entity.ToTable("R_ATRIBUTO");

            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.AtCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AT_CAMPO");
            entity.Property(e => e.AtActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AT_ACTIVO");
            entity.Property(e => e.AtAncho).HasColumnName("AT_ANCHO");
            entity.Property(e => e.AtClaves)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AT_CLAVES");
            entity.Property(e => e.AtConfi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AT_CONFI");
            entity.Property(e => e.AtDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AT_DESCRIP");
            entity.Property(e => e.AtEntidad).HasColumnName("AT_ENTIDAD");
            entity.Property(e => e.AtFiltro).HasColumnName("AT_FILTRO");
            entity.Property(e => e.AtFiltroa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AT_FILTROA");
            entity.Property(e => e.AtMascara)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AT_MASCARA");
            entity.Property(e => e.AtSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AT_SISTEMA");
            entity.Property(e => e.AtTcorto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("AT_TCORTO");
            entity.Property(e => e.AtTipo).HasColumnName("AT_TIPO");
            entity.Property(e => e.AtTitulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AT_TITULO");
            entity.Property(e => e.AtTotal).HasColumnName("AT_TOTAL");
            entity.Property(e => e.AtTrango).HasColumnName("AT_TRANGO");
            entity.Property(e => e.AtValorac).HasColumnName("AT_VALORAC");
            entity.Property(e => e.AtVersion).HasColumnName("AT_VERSION");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.LvCodigo).HasColumnName("LV_CODIGO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.EnCodigoNavigation).WithMany(p => p.RAtributos)
                .HasForeignKey(d => d.EnCodigo)
                .HasConstraintName("FK_R_ATRIBUTO_ENTIDAD");
        });

        modelBuilder.Entity<RClasAcc>(entity =>
        {
            entity.HasKey(e => new { e.CmCodigo, e.GrCodigo, e.RcCodigo }).HasName("PK__R_CLAS_ACC__6319B466");

            entity.ToTable("R_CLAS_ACC");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.RcCodigo).HasColumnName("RC_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RaDerecho).HasColumnName("RA_DERECHO");
            entity.Property(e => e.RaVersion).HasColumnName("RA_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.RcCodigoNavigation).WithMany(p => p.RClasAccs)
                .HasForeignKey(d => d.RcCodigo)
                .HasConstraintName("FK_R_CLAS_ACC");
        });

        modelBuilder.Entity<RClasEnt>(entity =>
        {
            entity.HasKey(e => new { e.RcCodigo, e.CeOrden }).HasName("PK__R_CLAS_ENT__66EA454A");

            entity.ToTable("R_CLAS_ENT");

            entity.Property(e => e.RcCodigo).HasColumnName("RC_CODIGO");
            entity.Property(e => e.CeOrden).HasColumnName("CE_ORDEN");
            entity.Property(e => e.CeVersion).HasColumnName("CE_VERSION");
            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.RcCodigoNavigation).WithMany(p => p.RClasEnts)
                .HasForeignKey(d => d.RcCodigo)
                .HasConstraintName("FK_R_CLAS_ENT_CLASIFI");
        });

        modelBuilder.Entity<RClasifi>(entity =>
        {
            entity.HasKey(e => e.RcCodigo).HasName("PK__R_CLASIFI__61316BF4");

            entity.ToTable("R_CLASIFI");

            entity.HasIndex(e => e.RcNombre, "XAK1R_CLASIFI").IsUnique();

            entity.Property(e => e.RcCodigo)
                .ValueGeneratedNever()
                .HasColumnName("RC_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RcActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RC_ACTIVO");
            entity.Property(e => e.RcModulo).HasColumnName("RC_MODULO");
            entity.Property(e => e.RcNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RC_NOMBRE");
            entity.Property(e => e.RcOrden).HasColumnName("RC_ORDEN");
            entity.Property(e => e.RcVersion).HasColumnName("RC_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<RDatosdef>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("R_DATOSDEF");

            entity.Property(e => e.AtCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AT_CAMPO");
            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.RdEntidad).HasColumnName("RD_ENTIDAD");
            entity.Property(e => e.RdOrden).HasColumnName("RD_ORDEN");
            entity.Property(e => e.RdVersion).HasColumnName("RD_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<RDefault>(entity =>
        {
            entity.HasKey(e => new { e.EnCodigo, e.RdOrden }).HasName("PK__R_DEFAULT__7073AF84");

            entity.ToTable("R_DEFAULT");

            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.RdOrden).HasColumnName("RD_ORDEN");
            entity.Property(e => e.AtCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AT_CAMPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RdEntidad).HasColumnName("RD_ENTIDAD");
            entity.Property(e => e.RdVersion).HasColumnName("RD_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.EnCodigoNavigation).WithMany(p => p.RDefaults)
                .HasForeignKey(d => d.EnCodigo)
                .HasConstraintName("FK_R_DEFAULT_R_ENTIDAD");
        });

        modelBuilder.Entity<REntAcc>(entity =>
        {
            entity.HasKey(e => new { e.CmCodigo, e.GrCodigo, e.EnCodigo }).HasName("PK__R_ENT_ACC__6501FCD8");

            entity.ToTable("R_ENT_ACC");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.ReDerecho).HasColumnName("RE_DERECHO");
            entity.Property(e => e.ReVersion).HasColumnName("RE_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<REntidad>(entity =>
        {
            entity.HasKey(e => e.EnCodigo).HasName("PK__R_ENTIDAD__5B78929E");

            entity.ToTable("R_ENTIDAD", tb =>
                {
                    tb.HasTrigger("TD_R_ENTIDAD");
                    tb.HasTrigger("TU_R_ENTIDAD");
                });

            entity.Property(e => e.EnCodigo)
                .ValueGeneratedNever()
                .HasColumnName("EN_CODIGO");
            entity.Property(e => e.EnActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EN_ACTIVO");
            entity.Property(e => e.EnAlias).HasColumnName("EN_ALIAS");
            entity.Property(e => e.EnAtdesc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EN_ATDESC");
            entity.Property(e => e.EnDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EN_DESCRIP");
            entity.Property(e => e.EnPrimary)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EN_PRIMARY");
            entity.Property(e => e.EnTabla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EN_TABLA");
            entity.Property(e => e.EnTitulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EN_TITULO");
            entity.Property(e => e.EnVersion).HasColumnName("EN_VERSION");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<RFiltro>(entity =>
        {
            entity.HasKey(e => new { e.EnCodigo, e.RfOrden }).HasName("PK__R_FILTRO__6E8B6712");

            entity.ToTable("R_FILTRO");

            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.RfOrden).HasColumnName("RF_ORDEN");
            entity.Property(e => e.AtCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AT_CAMPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RfEntidad).HasColumnName("RF_ENTIDAD");
            entity.Property(e => e.RfVersion).HasColumnName("RF_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.EnCodigoNavigation).WithMany(p => p.RFiltros)
                .HasForeignKey(d => d.EnCodigo)
                .HasConstraintName("FK_R_FILTRO_R_ENTIDAD");
        });

        modelBuilder.Entity<RListaval>(entity =>
        {
            entity.HasKey(e => e.LvCodigo).HasName("PK__R_LISTAVAL__57A801BA");

            entity.ToTable("R_LISTAVAL", tb => tb.HasTrigger("TU_R_LISTAVAL"));

            entity.HasIndex(e => e.LvNombre, "XAK1R_LISTAVAL").IsUnique();

            entity.Property(e => e.LvCodigo)
                .ValueGeneratedNever()
                .HasColumnName("LV_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.LvActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LV_ACTIVO");
            entity.Property(e => e.LvNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LV_NOMBRE");
            entity.Property(e => e.LvVersion).HasColumnName("LV_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<RModEnt>(entity =>
        {
            entity.HasKey(e => new { e.MoCodigo, e.MeOrden }).HasName("PK__R_MOD_ENT__6ABAD62E");

            entity.ToTable("R_MOD_ENT");

            entity.Property(e => e.MoCodigo).HasColumnName("MO_CODIGO");
            entity.Property(e => e.MeOrden).HasColumnName("ME_ORDEN");
            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MeVersion).HasColumnName("ME_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.MoCodigoNavigation).WithMany(p => p.RModEnts)
                .HasForeignKey(d => d.MoCodigo)
                .HasConstraintName("FK_R_MOD_ENT_MODULO");
        });

        modelBuilder.Entity<RModulo>(entity =>
        {
            entity.HasKey(e => e.MoCodigo).HasName("PK__R_MODULO__68D28DBC");

            entity.ToTable("R_MODULO");

            entity.HasIndex(e => e.MoNombre, "XAK1R_MODULO").IsUnique();

            entity.Property(e => e.MoCodigo)
                .ValueGeneratedNever()
                .HasColumnName("MO_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MoActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MO_ACTIVO");
            entity.Property(e => e.MoNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MO_NOMBRE");
            entity.Property(e => e.MoOrden).HasColumnName("MO_ORDEN");
            entity.Property(e => e.MoVersion).HasColumnName("MO_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<ROrden>(entity =>
        {
            entity.HasKey(e => new { e.EnCodigo, e.RoOrden }).HasName("PK__R_ORDEN__6CA31EA0");

            entity.ToTable("R_ORDEN");

            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.RoOrden).HasColumnName("RO_ORDEN");
            entity.Property(e => e.AtCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AT_CAMPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RoEntidad).HasColumnName("RO_ENTIDAD");
            entity.Property(e => e.RoVersion).HasColumnName("RO_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.EnCodigoNavigation).WithMany(p => p.ROrdens)
                .HasForeignKey(d => d.EnCodigo)
                .HasConstraintName("FK_R_ORDEN_R_ENTIDAD");
        });

        modelBuilder.Entity<RRelacion>(entity =>
        {
            entity.HasKey(e => new { e.EnCodigo, e.RlOrden }).HasName("PK__R_RELACION__5F492382");

            entity.ToTable("R_RELACION");

            entity.Property(e => e.EnCodigo).HasColumnName("EN_CODIGO");
            entity.Property(e => e.RlOrden).HasColumnName("RL_ORDEN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RlActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RL_ACTIVO");
            entity.Property(e => e.RlCampos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RL_CAMPOS");
            entity.Property(e => e.RlEntidad).HasColumnName("RL_ENTIDAD");
            entity.Property(e => e.RlInner)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RL_INNER");
            entity.Property(e => e.RlVersion).HasColumnName("RL_VERSION");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.EnCodigoNavigation).WithMany(p => p.RRelacions)
                .HasForeignKey(d => d.EnCodigo)
                .HasConstraintName("FK_R_RELACION_ENTIDAD");
        });

        modelBuilder.Entity<RValor>(entity =>
        {
            entity.HasKey(e => new { e.LvCodigo, e.VlCodigo }).HasName("PK__R_VALOR__59904A2C");

            entity.ToTable("R_VALOR");

            entity.Property(e => e.LvCodigo).HasColumnName("LV_CODIGO");
            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.VlDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VL_DESCRIP");
            entity.Property(e => e.VlVersion).HasColumnName("VL_VERSION");

            entity.HasOne(d => d.LvCodigoNavigation).WithMany(p => p.RValors)
                .HasForeignKey(d => d.LvCodigo)
                .HasConstraintName("FK_R_VALOR");
        });

        modelBuilder.Entity<Reglaprest>(entity =>
        {
            entity.HasKey(e => e.RpCodigo);

            entity.ToTable("REGLAPREST");

            entity.Property(e => e.RpCodigo)
                .ValueGeneratedNever()
                .HasColumnName("RP_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.QuCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CODIGO");
            entity.Property(e => e.RpActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RP_ACTIVO");
            entity.Property(e => e.RpAntFin).HasColumnName("RP_ANT_FIN");
            entity.Property(e => e.RpAntIni).HasColumnName("RP_ANT_INI");
            entity.Property(e => e.RpEmpSts).HasColumnName("RP_EMP_STS");
            entity.Property(e => e.RpFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RP_FILTRO");
            entity.Property(e => e.RpLetrero)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RP_LETRERO");
            entity.Property(e => e.RpLimite).HasColumnName("RP_LIMITE");
            entity.Property(e => e.RpLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RP_LISTA");
            entity.Property(e => e.RpOrden).HasColumnName("RP_ORDEN");
            entity.Property(e => e.RpPreSts).HasColumnName("RP_PRE_STS");
            entity.Property(e => e.RpTope)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RP_TOPE");
            entity.Property(e => e.RpValFec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RP_VAL_FEC");
        });

        modelBuilder.Entity<RepAho>(entity =>
        {
            entity.HasKey(e => new { e.RaYear, e.TbCodigo, e.CbCodigo });

            entity.ToTable("REP_AHO");

            entity.Property(e => e.RaYear).HasColumnName("RA_YEAR");
            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RaAhorro)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RA_AHORRO");
            entity.Property(e => e.RaReparto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RA_REPARTO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.RepAhos)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Rep_Aho_Colabora");

            entity.HasOne(d => d.TbCodigoNavigation).WithMany(p => p.RepAhos)
                .HasForeignKey(d => d.TbCodigo)
                .HasConstraintName("FK_Rep_Aho_TAhorro");
        });

        modelBuilder.Entity<RepEmp>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo });

            entity.ToTable("REP_EMPS");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<RepPtu>(entity =>
        {
            entity.HasKey(e => new { e.RuYear, e.CbCodigo });

            entity.ToTable("REP_PTU");

            entity.Property(e => e.RuYear).HasColumnName("RU_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RuDias).HasColumnName("RU_DIAS");
            entity.Property(e => e.RuMDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RU_M_DIAS");
            entity.Property(e => e.RuMMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RU_M_MONTO");
            entity.Property(e => e.RuMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RU_MONTO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.RepPtus)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Rep_Ptu_Colabora");
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.HasKey(e => e.ReCodigo);

            entity.ToTable("REPORTE");

            entity.HasIndex(e => e.ReNombre, "XAK1REPORTE").IsUnique();

            entity.HasIndex(e => new { e.ReClasifi, e.ReNombre }, "XIE1REPORTE");

            entity.Property(e => e.ReCodigo)
                .ValueGeneratedNever()
                .HasColumnName("RE_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.QuCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CODIGO");
            entity.Property(e => e.ReAlto)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_ALTO");
            entity.Property(e => e.ReAncho)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_ANCHO");
            entity.Property(e => e.ReArchivo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RE_ARCHIVO");
            entity.Property(e => e.ReCandado).HasColumnName("RE_CANDADO");
            entity.Property(e => e.ReCfecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RE_CFECHA");
            entity.Property(e => e.ReClasifi).HasColumnName("RE_CLASIFI");
            entity.Property(e => e.ReColespa)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_COLESPA");
            entity.Property(e => e.ReColnum).HasColumnName("RE_COLNUM");
            entity.Property(e => e.ReCopias).HasColumnName("RE_COPIAS");
            entity.Property(e => e.ReEntidad).HasColumnName("RE_ENTIDAD");
            entity.Property(e => e.ReFecha)
                .HasColumnType("datetime")
                .HasColumnName("RE_FECHA");
            entity.Property(e => e.ReFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RE_FILTRO");
            entity.Property(e => e.ReFontnam)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("RE_FONTNAM");
            entity.Property(e => e.ReFontsiz).HasColumnName("RE_FONTSIZ");
            entity.Property(e => e.ReGeneral)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RE_GENERAL");
            entity.Property(e => e.ReHoja).HasColumnName("RE_HOJA");
            entity.Property(e => e.ReIfecha).HasColumnName("RE_IFECHA");
            entity.Property(e => e.ReMarDer)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_DER");
            entity.Property(e => e.ReMarInf)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_INF");
            entity.Property(e => e.ReMarIzq)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_IZQ");
            entity.Property(e => e.ReMarSup)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_SUP");
            entity.Property(e => e.ReNivel).HasColumnName("RE_NIVEL");
            entity.Property(e => e.ReNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RE_NOMBRE");
            entity.Property(e => e.RePfile).HasColumnName("RE_PFILE");
            entity.Property(e => e.RePrinter)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RE_PRINTER");
            entity.Property(e => e.ReRenespa)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_RENESPA");
            entity.Property(e => e.ReReporte)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RE_REPORTE");
            entity.Property(e => e.ReSolot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RE_SOLOT");
            entity.Property(e => e.ReTipo).HasColumnName("RE_TIPO");
            entity.Property(e => e.ReTitulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RE_TITULO");
            entity.Property(e => e.ReVertica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RE_VERTICA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");

            entity.HasOne(d => d.ReClasifiNavigation).WithMany(p => p.Reportes)
                .HasForeignKey(d => d.ReClasifi)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REPORTE_R_CLASIFI");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.RvFolio);

            entity.ToTable("RESERVA");

            entity.Property(e => e.RvFolio)
                .ValueGeneratedNever()
                .HasColumnName("RV_FOLIO");
            entity.Property(e => e.AlCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AL_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
            entity.Property(e => e.RvDetalle)
                .HasColumnType("text")
                .HasColumnName("RV_DETALLE");
            entity.Property(e => e.RvDuracio)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RV_DURACIO");
            entity.Property(e => e.RvFecFin)
                .HasColumnType("datetime")
                .HasColumnName("RV_FEC_FIN");
            entity.Property(e => e.RvFecIni)
                .HasColumnType("datetime")
                .HasColumnName("RV_FEC_INI");
            entity.Property(e => e.RvFecRes)
                .HasColumnType("datetime")
                .HasColumnName("RV_FEC_RES");
            entity.Property(e => e.RvHorFin)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RV_HOR_FIN");
            entity.Property(e => e.RvHorIni)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RV_HOR_INI");
            entity.Property(e => e.RvHorRes)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RV_HOR_RES");
            entity.Property(e => e.RvLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RV_LISTA");
            entity.Property(e => e.RvOrden)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RV_ORDEN");
            entity.Property(e => e.RvResumen)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RV_RESUMEN");
            entity.Property(e => e.RvTipo).HasColumnName("RV_TIPO");
            entity.Property(e => e.SeFolio).HasColumnName("SE_FOLIO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Riesgo>(entity =>
        {
            entity.HasKey(e => new { e.RiClase, e.RiGrado });

            entity.ToTable("RIESGO");

            entity.Property(e => e.RiClase).HasColumnName("RI_CLASE");
            entity.Property(e => e.RiGrado).HasColumnName("RI_GRADO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RiIndice).HasColumnName("RI_INDICE");
            entity.Property(e => e.RiPrima)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RI_PRIMA");
        });

        modelBuilder.Entity<Rpatron>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("RPATRON", tb => tb.HasTrigger("TU_RPATRON"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RsCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RS_CODIGO");
            entity.Property(e => e.TbCalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_CALLE");
            entity.Property(e => e.TbCiudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_CIUDAD");
            entity.Property(e => e.TbClase).HasColumnName("TB_CLASE");
            entity.Property(e => e.TbCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TB_CODPOST");
            entity.Property(e => e.TbColonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_COLONIA");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TB_EMAIL");
            entity.Property(e => e.TbEntidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ENTIDAD");
            entity.Property(e => e.TbFax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_FAX");
            entity.Property(e => e.TbFracc).HasColumnName("TB_FRACC");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbModulo).HasColumnName("TB_MODULO");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbNumext)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TB_NUMEXT");
            entity.Property(e => e.TbNumint)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TB_NUMINT");
            entity.Property(e => e.TbNumreg)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("TB_NUMREG");
            entity.Property(e => e.TbPlanfol)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TB_PLANFOL");
            entity.Property(e => e.TbPlanper)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_PLANPER");
            entity.Property(e => e.TbPlanpre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_PLANPRE");
            entity.Property(e => e.TbSiem)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TB_SIEM");
            entity.Property(e => e.TbStyps)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_STYPS");
            entity.Property(e => e.TbTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEL");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbWeb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TB_WEB");

            entity.HasOne(d => d.RsCodigoNavigation).WithMany(p => p.Rpatrons)
                .HasForeignKey(d => d.RsCodigo)
                .HasConstraintName("FK_RPatron_RSocial");
        });

        modelBuilder.Entity<Rsocial>(entity =>
        {
            entity.HasKey(e => e.RsCodigo);

            entity.ToTable("RSOCIAL");

            entity.Property(e => e.RsCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RS_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.RsCalle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_CALLE");
            entity.Property(e => e.RsCert)
                .HasColumnType("text")
                .HasColumnName("RS_CERT");
            entity.Property(e => e.RsCiudad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_CIUDAD");
            entity.Property(e => e.RsCodpost)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RS_CODPOST");
            entity.Property(e => e.RsColonia)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_COLONIA");
            entity.Property(e => e.RsCurp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_CURP");
            entity.Property(e => e.RsEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RS_EMAIL");
            entity.Property(e => e.RsEntidad)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RS_ENTIDAD");
            entity.Property(e => e.RsFax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_FAX");
            entity.Property(e => e.RsGiro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RS_GIRO");
            entity.Property(e => e.RsGuia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_GUIA");
            entity.Property(e => e.RsInfo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_INFO");
            entity.Property(e => e.RsIssueby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RS_ISSUEBY");
            entity.Property(e => e.RsIssueto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RS_ISSUETO");
            entity.Property(e => e.RsKeyPr)
                .HasColumnType("text")
                .HasColumnName("RS_KEY_PR");
            entity.Property(e => e.RsKeyPu)
                .HasColumnType("text")
                .HasColumnName("RS_KEY_PU");
            entity.Property(e => e.RsNombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_NOMBRE");
            entity.Property(e => e.RsNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("RS_NUMERO");
            entity.Property(e => e.RsNumext)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RS_NUMEXT");
            entity.Property(e => e.RsNumint)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RS_NUMINT");
            entity.Property(e => e.RsRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_RFC");
            entity.Property(e => e.RsRlCurp)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_RL_CURP");
            entity.Property(e => e.RsRlRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_RL_RFC");
            entity.Property(e => e.RsRlegal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_RLEGAL");
            entity.Property(e => e.RsSello)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RS_SELLO");
            entity.Property(e => e.RsSerial)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_SERIAL");
            entity.Property(e => e.RsStps)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_STPS");
            entity.Property(e => e.RsStpsR1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_STPS_R1");
            entity.Property(e => e.RsStpsR2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RS_STPS_R2");
            entity.Property(e => e.RsSubsid)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("RS_SUBSID");
            entity.Property(e => e.RsTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_TEL");
            entity.Property(e => e.RsTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RS_TEXTO");
            entity.Property(e => e.RsValFin)
                .HasColumnType("datetime")
                .HasColumnName("RS_VAL_FIN");
            entity.Property(e => e.RsValIni)
                .HasColumnType("datetime")
                .HasColumnName("RS_VAL_INI");
            entity.Property(e => e.RsWeb)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RS_WEB");
        });

        modelBuilder.Entity<SalMin>(entity =>
        {
            entity.HasKey(e => e.SmFecIni);

            entity.ToTable("SAL_MIN");

            entity.Property(e => e.SmFecIni)
                .HasColumnType("datetime")
                .HasColumnName("SM_FEC_INI");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.SmZonaA)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SM_ZONA_A");
            entity.Property(e => e.SmZonaB)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SM_ZONA_B");
            entity.Property(e => e.SmZonaC)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SM_ZONA_C");
        });

        modelBuilder.Entity<Scrap>(entity =>
        {
            entity.HasKey(e => new { e.CsFolio, e.ScFolio });

            entity.ToTable("SCRAP");

            entity.Property(e => e.CsFolio).HasColumnName("CS_FOLIO");
            entity.Property(e => e.ScFolio).HasColumnName("SC_FOLIO");
            entity.Property(e => e.CnCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CN_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.ScComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("SC_COMENTA");
            entity.Property(e => e.ScMotivo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SC_MOTIVO");
            entity.Property(e => e.ScPiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("SC_PIEZAS");

            entity.HasOne(d => d.CnCodigoNavigation).WithMany(p => p.Scraps)
                .HasForeignKey(d => d.CnCodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SCRAP_COMPONEN");

            entity.HasOne(d => d.CsFolioNavigation).WithMany(p => p.Scraps)
                .HasForeignKey(d => d.CsFolio)
                .HasConstraintName("FK_SCRAP_CEDSCRAP");

            entity.HasOne(d => d.ScMotivoNavigation).WithMany(p => p.Scraps)
                .HasForeignKey(d => d.ScMotivo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SCRAP_MOTSCRAP");
        });

        modelBuilder.Entity<ScrapV>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SCRAP_V");

            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CnCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CN_CODIGO");
            entity.Property(e => e.CsArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CS_AREA");
            entity.Property(e => e.CsComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CS_COMENTA");
            entity.Property(e => e.CsFecFab)
                .HasColumnType("datetime")
                .HasColumnName("CS_FEC_FAB");
            entity.Property(e => e.CsFecha)
                .HasColumnType("datetime")
                .HasColumnName("CS_FECHA");
            entity.Property(e => e.CsFolio).HasColumnName("CS_FOLIO");
            entity.Property(e => e.CsHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CS_HORA");
            entity.Property(e => e.CsNumero1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_NUMERO1");
            entity.Property(e => e.CsNumero2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CS_NUMERO2");
            entity.Property(e => e.CsObserva)
                .HasColumnType("text")
                .HasColumnName("CS_OBSERVA");
            entity.Property(e => e.CsTamlote)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CS_TAMLOTE");
            entity.Property(e => e.CsTexto1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CS_TEXTO1");
            entity.Property(e => e.CsTexto2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CS_TEXTO2");
            entity.Property(e => e.DeComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DE_COMENTA");
            entity.Property(e => e.DePiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("DE_PIEZAS");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.ScFolio).HasColumnName("SC_FOLIO");
            entity.Property(e => e.ScMotivo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SC_MOTIVO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        modelBuilder.Entity<Sesion>(entity =>
        {
            entity.HasKey(e => e.SeFolio);

            entity.ToTable("SESION", tb =>
                {
                    tb.HasTrigger("TD_SESION");
                    tb.HasTrigger("TU_SESION");
                });

            entity.Property(e => e.SeFolio)
                .ValueGeneratedNever()
                .HasColumnName("SE_FOLIO");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
            entity.Property(e => e.SeComenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SE_COMENTA");
            entity.Property(e => e.SeCosto1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SE_COSTO1");
            entity.Property(e => e.SeCosto2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SE_COSTO2");
            entity.Property(e => e.SeCosto3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SE_COSTO3");
            entity.Property(e => e.SeCupo).HasColumnName("SE_CUPO");
            entity.Property(e => e.SeEst)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SE_EST");
            entity.Property(e => e.SeFecFin)
                .HasColumnType("datetime")
                .HasColumnName("SE_FEC_FIN");
            entity.Property(e => e.SeFecIni)
                .HasColumnType("datetime")
                .HasColumnName("SE_FEC_INI");
            entity.Property(e => e.SeHorFin)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SE_HOR_FIN");
            entity.Property(e => e.SeHorIni)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SE_HOR_INI");
            entity.Property(e => e.SeHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SE_HORAS");
            entity.Property(e => e.SeLugar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SE_LUGAR");
            entity.Property(e => e.SeRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SE_REVISIO");
            entity.Property(e => e.SeStatus).HasColumnName("SE_STATUS");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Ssocial>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("SSOCIAL", tb => tb.HasTrigger("TU_SSOCIAL"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_ACTIVO");
            entity.Property(e => e.TbDiasAd)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_DIAS_AD");
            entity.Property(e => e.TbDiasAg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_DIAS_AG");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbPago7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_PAGO_7");
            entity.Property(e => e.TbPrima7)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_PRIMA_7");
            entity.Property(e => e.TbPrimado)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_PRIMADO");
            entity.Property(e => e.TbPrimava)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_PRIMAVA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Step>(entity =>
        {
            entity.HasKey(e => new { e.WoNumber, e.StSequenc });

            entity.ToTable("STEPS");

            entity.HasIndex(e => new { e.WoNumber, e.OpNumber }, "XIE1STEPS");

            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
            entity.Property(e => e.StSequenc).HasColumnName("ST_SEQUENC");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.StQty)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("ST_QTY");
            entity.Property(e => e.StRealHr)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("ST_REAL_HR");
            entity.Property(e => e.StStdHr)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("ST_STD_HR");

            entity.HasOne(d => d.WoNumberNavigation).WithMany(p => p.Steps)
                .HasForeignKey(d => d.WoNumber)
                .HasConstraintName("FK_Steps_Worder");
        });

        modelBuilder.Entity<SupArea>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbArea });

            entity.ToTable("SUP_AREA");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AREA");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Super>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbNivel });

            entity.ToTable("SUPER");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbNivel)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_NIVEL");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<Suscrip>(entity =>
        {
            entity.HasKey(e => new { e.ReCodigo, e.UsCodigo });

            entity.ToTable("SUSCRIP");

            entity.Property(e => e.ReCodigo).HasColumnName("RE_CODIGO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.SuEnviar).HasColumnName("SU_ENVIAR");
            entity.Property(e => e.SuFrecuen).HasColumnName("SU_FRECUEN");
            entity.Property(e => e.SuVacio).HasColumnName("SU_VACIO");

            entity.HasOne(d => d.ReCodigoNavigation).WithMany(p => p.Suscrips)
                .HasForeignKey(d => d.ReCodigo)
                .HasConstraintName("FK_Suscrip_Reporte");
        });

        modelBuilder.Entity<TArt80>(entity =>
        {
            entity.HasKey(e => new { e.NuCodigo, e.TiInicio });

            entity.ToTable("T_ART_80");

            entity.Property(e => e.NuCodigo).HasColumnName("NU_CODIGO");
            entity.Property(e => e.TiInicio)
                .HasColumnType("datetime")
                .HasColumnName("TI_INICIO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TiDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TI_DESCRIP");

            entity.HasOne(d => d.NuCodigoNavigation).WithMany(p => p.TArt80s)
                .HasForeignKey(d => d.NuCodigo)
                .HasConstraintName("FK_T_ART_80_Numerica");
        });

        modelBuilder.Entity<Tacciden>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TACCIDEN", tb => tb.HasTrigger("TU_TACCIDEN"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Tahorro>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TAHORRO");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbAlta).HasColumnName("TB_ALTA");
            entity.Property(e => e.TbConcept).HasColumnName("TB_CONCEPT");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbFecFin)
                .HasColumnType("datetime")
                .HasColumnName("TB_FEC_FIN");
            entity.Property(e => e.TbFecIni)
                .HasColumnType("datetime")
                .HasColumnName("TB_FEC_INI");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbLiquida).HasColumnName("TB_LIQUIDA");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbPresta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_PRESTA");
            entity.Property(e => e.TbPriorid).HasColumnName("TB_PRIORID");
            entity.Property(e => e.TbRelativ).HasColumnName("TB_RELATIV");
            entity.Property(e => e.TbTasa1)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA1");
            entity.Property(e => e.TbTasa2)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA2");
            entity.Property(e => e.TbTasa3)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA3");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbValRan)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_VAL_RAN");
        });

        modelBuilder.Entity<Talla>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TALLA", tb =>
                {
                    tb.HasTrigger("TD_TALLA");
                    tb.HasTrigger("TU_TALLA");
                });

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Tcambio>(entity =>
        {
            entity.HasKey(e => e.TcFecIni);

            entity.ToTable("TCAMBIO");

            entity.Property(e => e.TcFecIni)
                .HasColumnType("datetime")
                .HasColumnName("TC_FEC_INI");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TcMonto)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TC_MONTO");
            entity.Property(e => e.TcNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TC_NUMERO");
            entity.Property(e => e.TcTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TC_TEXTO");
        });

        modelBuilder.Entity<Tcompete>(entity =>
        {
            entity.HasKey(e => e.TcCodigo);

            entity.ToTable("TCOMPETE", tb =>
                {
                    tb.HasTrigger("TD_TCOMPETE");
                    tb.HasTrigger("TU_TCOMPETE");
                });

            entity.Property(e => e.TcCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TC_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TcDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TC_DESCRIP");
            entity.Property(e => e.TcIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TC_INGLES");
            entity.Property(e => e.TcNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TC_NUMERO");
            entity.Property(e => e.TcTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TC_TEXTO");
            entity.Property(e => e.TcTipo).HasColumnName("TC_TIPO");
        });

        modelBuilder.Entity<Tconsltum>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TCONSLTA", tb => tb.HasTrigger("TU_TCONSLTA"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Tctamov>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TCTAMOVS", tb => tb.HasTrigger("TU_TCTAMOVS"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_SISTEMA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Tcurso>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TCURSO", tb => tb.HasTrigger("TU_TCURSO"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Tdefecto>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TDEFECTO");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Testudio>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TESTUDIO", tb => tb.HasTrigger("TU_TESTUDIO"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
            entity.Property(e => e.TbTipo).HasColumnName("TB_TIPO");
        });

        modelBuilder.Entity<Tfija>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TFIJAS");

            entity.Property(e => e.TfCodigo).HasColumnName("TF_CODIGO");
            entity.Property(e => e.TfDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TF_DESCRIP");
            entity.Property(e => e.TfTabla).HasColumnName("TF_TABLA");
        });

        modelBuilder.Entity<Tkardex>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TKARDEX");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNivel).HasColumnName("TB_NIVEL");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbSistema)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_SISTEMA");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Tmpbala2>(entity =>
        {
            entity.HasKey(e => new { e.TpUser, e.TpNivel1, e.TpNivel2, e.TpNivel3, e.TpNivel4, e.TpNivel5, e.CbCodigo, e.TpOrden }).HasName("PK__TMPBALA2__65370702");

            entity.ToTable("TMPBALA2");

            entity.Property(e => e.TpUser).HasColumnName("TP_USER");
            entity.Property(e => e.TpNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_NIVEL1");
            entity.Property(e => e.TpNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_NIVEL2");
            entity.Property(e => e.TpNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_NIVEL3");
            entity.Property(e => e.TpNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_NIVEL4");
            entity.Property(e => e.TpNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_NIVEL5");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TpOrden).HasColumnName("TP_ORDEN");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.TpDesDed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TP_DES_DED");
            entity.Property(e => e.TpDesPer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TP_DES_PER");
            entity.Property(e => e.TpEmplead)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TP_EMPLEAD");
            entity.Property(e => e.TpHorDed)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_HOR_DED");
            entity.Property(e => e.TpHorPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_HOR_PER");
            entity.Property(e => e.TpMonDed)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_MON_DED");
            entity.Property(e => e.TpMonPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_MON_PER");
            entity.Property(e => e.TpNumDed).HasColumnName("TP_NUM_DED");
            entity.Property(e => e.TpNumPer).HasColumnName("TP_NUM_PER");
            entity.Property(e => e.TpRefDed)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TP_REF_DED");
            entity.Property(e => e.TpRefPer)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TP_REF_PER");
            entity.Property(e => e.TpTotal).HasColumnName("TP_TOTAL");
        });

        modelBuilder.Entity<Tmpbalan>(entity =>
        {
            entity.HasKey(e => new { e.TzUser, e.CbCodigo, e.TzCodigo });

            entity.ToTable("TMPBALAN");

            entity.Property(e => e.TzUser).HasColumnName("TZ_USER");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TzCodigo).HasColumnName("TZ_CODIGO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.TzDesDed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TZ_DES_DED");
            entity.Property(e => e.TzDesPer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TZ_DES_PER");
            entity.Property(e => e.TzHorDed)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TZ_HOR_DED");
            entity.Property(e => e.TzHorPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TZ_HOR_PER");
            entity.Property(e => e.TzMonDed)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TZ_MON_DED");
            entity.Property(e => e.TzMonPer)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TZ_MON_PER");
            entity.Property(e => e.TzNumDed).HasColumnName("TZ_NUM_DED");
            entity.Property(e => e.TzNumPer).HasColumnName("TZ_NUM_PER");
            entity.Property(e => e.TzRefDed)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TZ_REF_DED");
            entity.Property(e => e.TzRefPer)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TZ_REF_PER");
        });

        modelBuilder.Entity<Tmpcalen>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo, e.TlYear, e.TlMes });

            entity.ToTable("TMPCALEN");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TlYear).HasColumnName("TL_YEAR");
            entity.Property(e => e.TlMes).HasColumnName("TL_MES");
            entity.Property(e => e.TlDesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_DES_TRA");
            entity.Property(e => e.TlDescan).HasColumnName("TL_DESCAN");
            entity.Property(e => e.TlDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_DOBLES");
            entity.Property(e => e.TlExtras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_EXTRAS");
            entity.Property(e => e.TlFaltas).HasColumnName("TL_FALTAS");
            entity.Property(e => e.TlFecMax)
                .HasColumnType("datetime")
                .HasColumnName("TL_FEC_MAX");
            entity.Property(e => e.TlFecMin)
                .HasColumnType("datetime")
                .HasColumnName("TL_FEC_MIN");
            entity.Property(e => e.TlFecha01)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA01");
            entity.Property(e => e.TlFecha02)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA02");
            entity.Property(e => e.TlFecha03)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA03");
            entity.Property(e => e.TlFecha04)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA04");
            entity.Property(e => e.TlFecha05)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA05");
            entity.Property(e => e.TlFecha06)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA06");
            entity.Property(e => e.TlFecha07)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA07");
            entity.Property(e => e.TlFecha08)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA08");
            entity.Property(e => e.TlFecha09)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA09");
            entity.Property(e => e.TlFecha10)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA10");
            entity.Property(e => e.TlFecha11)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA11");
            entity.Property(e => e.TlFecha12)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA12");
            entity.Property(e => e.TlFecha13)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA13");
            entity.Property(e => e.TlFecha14)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA14");
            entity.Property(e => e.TlFecha15)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA15");
            entity.Property(e => e.TlFecha16)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA16");
            entity.Property(e => e.TlFecha17)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA17");
            entity.Property(e => e.TlFecha18)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA18");
            entity.Property(e => e.TlFecha19)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA19");
            entity.Property(e => e.TlFecha20)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA20");
            entity.Property(e => e.TlFecha21)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA21");
            entity.Property(e => e.TlFecha22)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA22");
            entity.Property(e => e.TlFecha23)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA23");
            entity.Property(e => e.TlFecha24)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA24");
            entity.Property(e => e.TlFecha25)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA25");
            entity.Property(e => e.TlFecha26)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA26");
            entity.Property(e => e.TlFecha27)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA27");
            entity.Property(e => e.TlFecha28)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA28");
            entity.Property(e => e.TlFecha29)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA29");
            entity.Property(e => e.TlFecha30)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA30");
            entity.Property(e => e.TlFecha31)
                .HasColumnType("datetime")
                .HasColumnName("TL_FECHA31");
            entity.Property(e => e.TlFestivo).HasColumnName("TL_FESTIVO");
            entity.Property(e => e.TlHabil).HasColumnName("TL_HABIL");
            entity.Property(e => e.TlHorCg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_HOR_CG");
            entity.Property(e => e.TlHorSg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_HOR_SG");
            entity.Property(e => e.TlHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_HORAS");
            entity.Property(e => e.TlIncapa).HasColumnName("TL_INCAPA");
            entity.Property(e => e.TlNoTrab).HasColumnName("TL_NO_TRAB");
            entity.Property(e => e.TlNormal).HasColumnName("TL_NORMAL");
            entity.Property(e => e.TlNumero).HasColumnName("TL_NUMERO");
            entity.Property(e => e.TlPerCg).HasColumnName("TL_PER_CG");
            entity.Property(e => e.TlPerFj).HasColumnName("TL_PER_FJ");
            entity.Property(e => e.TlPerOt).HasColumnName("TL_PER_OT");
            entity.Property(e => e.TlPerSg).HasColumnName("TL_PER_SG");
            entity.Property(e => e.TlRetardo).HasColumnName("TL_RETARDO");
            entity.Property(e => e.TlSabado).HasColumnName("TL_SABADO");
            entity.Property(e => e.TlSuspen).HasColumnName("TL_SUSPEN");
            entity.Property(e => e.TlTardes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_TARDES");
            entity.Property(e => e.TlTrabajo).HasColumnName("TL_TRABAJO");
            entity.Property(e => e.TlVaca).HasColumnName("TL_VACA");
        });

        modelBuilder.Entity<Tmpcalhr>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo, e.TlYear, e.TlMes, e.TlCampo });

            entity.ToTable("TMPCALHR");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TlYear).HasColumnName("TL_YEAR");
            entity.Property(e => e.TlMes).HasColumnName("TL_MES");
            entity.Property(e => e.TlCampo).HasColumnName("TL_CAMPO");
            entity.Property(e => e.TlCampo01)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO01");
            entity.Property(e => e.TlCampo02)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO02");
            entity.Property(e => e.TlCampo03)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO03");
            entity.Property(e => e.TlCampo04)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO04");
            entity.Property(e => e.TlCampo05)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO05");
            entity.Property(e => e.TlCampo06)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO06");
            entity.Property(e => e.TlCampo07)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO07");
            entity.Property(e => e.TlCampo08)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO08");
            entity.Property(e => e.TlCampo09)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO09");
            entity.Property(e => e.TlCampo10)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO10");
            entity.Property(e => e.TlCampo11)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO11");
            entity.Property(e => e.TlCampo12)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO12");
            entity.Property(e => e.TlCampo13)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO13");
            entity.Property(e => e.TlCampo14)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO14");
            entity.Property(e => e.TlCampo15)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO15");
            entity.Property(e => e.TlCampo16)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO16");
            entity.Property(e => e.TlCampo17)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO17");
            entity.Property(e => e.TlCampo18)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO18");
            entity.Property(e => e.TlCampo19)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO19");
            entity.Property(e => e.TlCampo20)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO20");
            entity.Property(e => e.TlCampo21)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO21");
            entity.Property(e => e.TlCampo22)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO22");
            entity.Property(e => e.TlCampo23)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO23");
            entity.Property(e => e.TlCampo24)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO24");
            entity.Property(e => e.TlCampo25)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO25");
            entity.Property(e => e.TlCampo26)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO26");
            entity.Property(e => e.TlCampo27)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO27");
            entity.Property(e => e.TlCampo28)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO28");
            entity.Property(e => e.TlCampo29)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO29");
            entity.Property(e => e.TlCampo30)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO30");
            entity.Property(e => e.TlCampo31)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_CAMPO31");
            entity.Property(e => e.TlDesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_DES_TRA");
            entity.Property(e => e.TlDescan).HasColumnName("TL_DESCAN");
            entity.Property(e => e.TlDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_DOBLES");
            entity.Property(e => e.TlExtras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_EXTRAS");
            entity.Property(e => e.TlFaltas).HasColumnName("TL_FALTAS");
            entity.Property(e => e.TlFecMax)
                .HasColumnType("datetime")
                .HasColumnName("TL_FEC_MAX");
            entity.Property(e => e.TlFecMin)
                .HasColumnType("datetime")
                .HasColumnName("TL_FEC_MIN");
            entity.Property(e => e.TlFestivo).HasColumnName("TL_FESTIVO");
            entity.Property(e => e.TlHabil).HasColumnName("TL_HABIL");
            entity.Property(e => e.TlHorCg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_HOR_CG");
            entity.Property(e => e.TlHorSg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_HOR_SG");
            entity.Property(e => e.TlHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_HORAS");
            entity.Property(e => e.TlIncapa).HasColumnName("TL_INCAPA");
            entity.Property(e => e.TlNoTrab).HasColumnName("TL_NO_TRAB");
            entity.Property(e => e.TlNormal).HasColumnName("TL_NORMAL");
            entity.Property(e => e.TlNumero).HasColumnName("TL_NUMERO");
            entity.Property(e => e.TlPerCg).HasColumnName("TL_PER_CG");
            entity.Property(e => e.TlPerFj).HasColumnName("TL_PER_FJ");
            entity.Property(e => e.TlPerOt).HasColumnName("TL_PER_OT");
            entity.Property(e => e.TlPerSg).HasColumnName("TL_PER_SG");
            entity.Property(e => e.TlRetardo).HasColumnName("TL_RETARDO");
            entity.Property(e => e.TlSabado).HasColumnName("TL_SABADO");
            entity.Property(e => e.TlSuspen).HasColumnName("TL_SUSPEN");
            entity.Property(e => e.TlTardes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TL_TARDES");
            entity.Property(e => e.TlTipo01)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO01");
            entity.Property(e => e.TlTipo02)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO02");
            entity.Property(e => e.TlTipo03)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO03");
            entity.Property(e => e.TlTipo04)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO04");
            entity.Property(e => e.TlTipo05)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO05");
            entity.Property(e => e.TlTipo06)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO06");
            entity.Property(e => e.TlTipo07)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO07");
            entity.Property(e => e.TlTipo08)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO08");
            entity.Property(e => e.TlTipo09)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO09");
            entity.Property(e => e.TlTipo10)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO10");
            entity.Property(e => e.TlTipo11)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO11");
            entity.Property(e => e.TlTipo12)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO12");
            entity.Property(e => e.TlTipo13)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO13");
            entity.Property(e => e.TlTipo14)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO14");
            entity.Property(e => e.TlTipo15)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO15");
            entity.Property(e => e.TlTipo16)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO16");
            entity.Property(e => e.TlTipo17)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO17");
            entity.Property(e => e.TlTipo18)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO18");
            entity.Property(e => e.TlTipo19)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO19");
            entity.Property(e => e.TlTipo20)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO20");
            entity.Property(e => e.TlTipo21)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO21");
            entity.Property(e => e.TlTipo22)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO22");
            entity.Property(e => e.TlTipo23)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO23");
            entity.Property(e => e.TlTipo24)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO24");
            entity.Property(e => e.TlTipo25)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO25");
            entity.Property(e => e.TlTipo26)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO26");
            entity.Property(e => e.TlTipo27)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO27");
            entity.Property(e => e.TlTipo28)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO28");
            entity.Property(e => e.TlTipo29)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO29");
            entity.Property(e => e.TlTipo30)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO30");
            entity.Property(e => e.TlTipo31)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_TIPO31");
            entity.Property(e => e.TlTrabajo).HasColumnName("TL_TRABAJO");
            entity.Property(e => e.TlVaca).HasColumnName("TL_VACA");
        });

        modelBuilder.Entity<Tmpdemo>(entity =>
        {
            entity.HasKey(e => new { e.TdUser, e.TdGrupo });

            entity.ToTable("TMPDEMO");

            entity.Property(e => e.TdUser).HasColumnName("TD_USER");
            entity.Property(e => e.TdGrupo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TD_GRUPO");
            entity.Property(e => e.TdAntavg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_ANTAVG");
            entity.Property(e => e.TdAntmax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_ANTMAX");
            entity.Property(e => e.TdAntmin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_ANTMIN");
            entity.Property(e => e.TdDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TD_DESCRIP");
            entity.Property(e => e.TdDiasavg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DIASAVG");
            entity.Property(e => e.TdDiasmax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DIASMAX");
            entity.Property(e => e.TdDiasmin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DIASMIN");
            entity.Property(e => e.TdEdadavg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_EDADAVG");
            entity.Property(e => e.TdEdadmax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_EDADMAX");
            entity.Property(e => e.TdEdadmin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_EDADMIN");
            entity.Property(e => e.TdEmpl).HasColumnName("TD_EMPL");
            entity.Property(e => e.TdEmpmax).HasColumnName("TD_EMPMAX");
            entity.Property(e => e.TdEmpmin).HasColumnName("TD_EMPMIN");
            entity.Property(e => e.TdEstudio).HasColumnName("TD_ESTUDIO");
            entity.Property(e => e.TdFamilia).HasColumnName("TD_FAMILIA");
            entity.Property(e => e.TdHijoavg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_HIJOAVG");
            entity.Property(e => e.TdHijomax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_HIJOMAX");
            entity.Property(e => e.TdHijomin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_HIJOMIN");
            entity.Property(e => e.TdHombres).HasColumnName("TD_HOMBRES");
            entity.Property(e => e.TdIdioma).HasColumnName("TD_IDIOMA");
            entity.Property(e => e.TdMica).HasColumnName("TD_MICA");
            entity.Property(e => e.TdMujeres).HasColumnName("TD_MUJERES");
            entity.Property(e => e.TdResavg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_RESAVG");
            entity.Property(e => e.TdResmax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_RESMAX");
            entity.Property(e => e.TdResmin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_RESMIN");
            entity.Property(e => e.TdSalavg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_SALAVG");
            entity.Property(e => e.TdSalmax)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_SALMAX");
            entity.Property(e => e.TdSalmin)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_SALMIN");
            entity.Property(e => e.TdTabula).HasColumnName("TD_TABULA");
        });

        modelBuilder.Entity<Tmpdimm>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.TdYear, e.CbCodigo });

            entity.ToTable("TMPDIMM");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.TdYear).HasColumnName("TD_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TdCuantos).HasColumnName("TD_CUANTOS");
            entity.Property(e => e.TdData01)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_01");
            entity.Property(e => e.TdData02)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_02");
            entity.Property(e => e.TdData03)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_03");
            entity.Property(e => e.TdData04)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_04");
            entity.Property(e => e.TdData05)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_05");
            entity.Property(e => e.TdData06)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_06");
            entity.Property(e => e.TdData07)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_07");
            entity.Property(e => e.TdData08)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_08");
            entity.Property(e => e.TdData09)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_09");
            entity.Property(e => e.TdData10)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_10");
            entity.Property(e => e.TdData11)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_11");
            entity.Property(e => e.TdData12)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_12");
            entity.Property(e => e.TdData13)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_13");
            entity.Property(e => e.TdData14)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_14");
            entity.Property(e => e.TdData15)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_15");
            entity.Property(e => e.TdData16)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_16");
            entity.Property(e => e.TdData17)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_17");
            entity.Property(e => e.TdData18)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_18");
            entity.Property(e => e.TdData19)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_19");
            entity.Property(e => e.TdData20)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_20");
            entity.Property(e => e.TdData21)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_21");
            entity.Property(e => e.TdData22)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_22");
            entity.Property(e => e.TdData23)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_23");
            entity.Property(e => e.TdData24)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_24");
            entity.Property(e => e.TdData25)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_25");
            entity.Property(e => e.TdData26)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_26");
            entity.Property(e => e.TdData27)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_27");
            entity.Property(e => e.TdData28)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_28");
            entity.Property(e => e.TdData29)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_29");
            entity.Property(e => e.TdData30)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_30");
            entity.Property(e => e.TdData31)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_31");
            entity.Property(e => e.TdData32)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_32");
            entity.Property(e => e.TdData33)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_33");
            entity.Property(e => e.TdData34)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_34");
            entity.Property(e => e.TdData35)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_35");
            entity.Property(e => e.TdData36)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_36");
            entity.Property(e => e.TdData37)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_37");
            entity.Property(e => e.TdData38)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_38");
            entity.Property(e => e.TdData39)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_39");
            entity.Property(e => e.TdData40)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_40");
            entity.Property(e => e.TdData41)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_41");
            entity.Property(e => e.TdData42)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_42");
            entity.Property(e => e.TdData43)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_43");
            entity.Property(e => e.TdData44)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_44");
            entity.Property(e => e.TdData45)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_45");
            entity.Property(e => e.TdData46)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_46");
            entity.Property(e => e.TdData47)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_47");
            entity.Property(e => e.TdData48)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_48");
            entity.Property(e => e.TdData49)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_49");
            entity.Property(e => e.TdData50)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_50");
            entity.Property(e => e.TdData51)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_51");
            entity.Property(e => e.TdData52)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_52");
            entity.Property(e => e.TdData53)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_53");
            entity.Property(e => e.TdData54)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_54");
            entity.Property(e => e.TdData55)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_55");
            entity.Property(e => e.TdData56)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_56");
            entity.Property(e => e.TdData57)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_57");
            entity.Property(e => e.TdData58)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_58");
            entity.Property(e => e.TdData59)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_59");
            entity.Property(e => e.TdData60)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_60");
            entity.Property(e => e.TdData61)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_61");
            entity.Property(e => e.TdData62)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_62");
            entity.Property(e => e.TdData63)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_63");
            entity.Property(e => e.TdData64)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_64");
            entity.Property(e => e.TdData65)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_65");
            entity.Property(e => e.TdData66)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_66");
            entity.Property(e => e.TdData67)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_67");
            entity.Property(e => e.TdData68)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_68");
            entity.Property(e => e.TdData69)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_69");
            entity.Property(e => e.TdData70)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_70");
            entity.Property(e => e.TdData71)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_71");
            entity.Property(e => e.TdData72)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_72");
            entity.Property(e => e.TdData73)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_73");
            entity.Property(e => e.TdData74)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_74");
            entity.Property(e => e.TdData75)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_75");
            entity.Property(e => e.TdData76)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_76");
            entity.Property(e => e.TdData77)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_77");
            entity.Property(e => e.TdData78)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_78");
            entity.Property(e => e.TdData79)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_79");
            entity.Property(e => e.TdData80)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_80");
            entity.Property(e => e.TdData81)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_81");
            entity.Property(e => e.TdData82)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_82");
            entity.Property(e => e.TdData83)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_83");
            entity.Property(e => e.TdData84)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_84");
            entity.Property(e => e.TdData85)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_85");
            entity.Property(e => e.TdData86)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_86");
            entity.Property(e => e.TdData87)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_87");
            entity.Property(e => e.TdData88)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_88");
            entity.Property(e => e.TdData89)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_89");
            entity.Property(e => e.TdData90)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_90");
            entity.Property(e => e.TdData91)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_91");
            entity.Property(e => e.TdData92)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_92");
            entity.Property(e => e.TdData93)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_93");
            entity.Property(e => e.TdData94)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_94");
            entity.Property(e => e.TdData95)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_95");
            entity.Property(e => e.TdData96)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_96");
            entity.Property(e => e.TdData97)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_97");
            entity.Property(e => e.TdData98)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_98");
            entity.Property(e => e.TdData99)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_99");
            entity.Property(e => e.TdDataA0)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_A0");
            entity.Property(e => e.TdDataA1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_A1");
            entity.Property(e => e.TdDataA2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TD_DATA_A2");
            entity.Property(e => e.TdDiges)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TD_DIGES");
            entity.Property(e => e.TdFecSel)
                .HasColumnType("datetime")
                .HasColumnName("TD_FEC_SEL");
            entity.Property(e => e.TdHorSel)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TD_HOR_SEL");
            entity.Property(e => e.TdMesFin).HasColumnName("TD_MES_FIN");
            entity.Property(e => e.TdMesIni).HasColumnName("TD_MES_INI");
            entity.Property(e => e.TdOrig)
                .HasColumnType("text")
                .HasColumnName("TD_ORIG");
            entity.Property(e => e.TdRepetid).HasColumnName("TD_REPETID");
            entity.Property(e => e.TdSello)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TD_SELLO");
            entity.Property(e => e.TdText01)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TD_TEXT_01");
            entity.Property(e => e.TdText02)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TD_TEXT_02");
            entity.Property(e => e.TdText03)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TD_TEXT_03");
            entity.Property(e => e.TdText04)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TD_TEXT_04");
            entity.Property(e => e.TdText05)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TD_TEXT_05");
        });

        modelBuilder.Entity<Tmpdimmtot>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.TdYear });

            entity.ToTable("TMPDIMMTOT");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.TdYear).HasColumnName("TD_YEAR");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TdStatus).HasColumnName("TD_STATUS");
        });

        modelBuilder.Entity<Tmpestad>(entity =>
        {
            entity.HasKey(e => new { e.TeUser, e.TeCodigo });

            entity.ToTable("TMPESTAD");

            entity.Property(e => e.TeUser).HasColumnName("TE_USER");
            entity.Property(e => e.TeCodigo).HasColumnName("TE_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TeAbono)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TE_ABONO");
            entity.Property(e => e.TeCargo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TE_CARGO");
            entity.Property(e => e.TeDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TE_DESCRIP");
            entity.Property(e => e.TeFecha)
                .HasColumnType("datetime")
                .HasColumnName("TE_FECHA");
            entity.Property(e => e.TeReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TE_REFEREN");
            entity.Property(e => e.TeSaldo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TE_SALDO");
            entity.Property(e => e.TeTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TE_TIPO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<Tmpevent>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo, e.TvFecha });

            entity.ToTable("TMPEVENT");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.TvFecha)
                .HasColumnType("datetime")
                .HasColumnName("TV_FECHA");
            entity.Property(e => e.CbActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_ACTIVO");
            entity.Property(e => e.CbAntig).HasColumnName("CB_ANTIG");
            entity.Property(e => e.CbFecIng)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ING");
            entity.Property(e => e.EvCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EV_CODIGO");
            entity.Property(e => e.Prettyname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PRETTYNAME");
            entity.Property(e => e.TvAlta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_ALTA");
            entity.Property(e => e.TvAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_AUTOSAL");
            entity.Property(e => e.TvBaja)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_BAJA");
            entity.Property(e => e.TvCampo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TV_CAMPO");
            entity.Property(e => e.TvClasifi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_CLASIFI");
            entity.Property(e => e.TvComent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TV_COMENT");
            entity.Property(e => e.TvContrat)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_CONTRAT");
            entity.Property(e => e.TvFecAnt)
                .HasColumnType("datetime")
                .HasColumnName("TV_FEC_ANT");
            entity.Property(e => e.TvFecBss)
                .HasColumnType("datetime")
                .HasColumnName("TV_FEC_BSS");
            entity.Property(e => e.TvFecCon)
                .HasColumnType("datetime")
                .HasColumnName("TV_FEC_CON");
            entity.Property(e => e.TvKardex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_KARDEX");
            entity.Property(e => e.TvMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TV_MONTO");
            entity.Property(e => e.TvMotBaj)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_MOT_BAJ");
            entity.Property(e => e.TvNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL1");
            entity.Property(e => e.TvNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL2");
            entity.Property(e => e.TvNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL3");
            entity.Property(e => e.TvNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL4");
            entity.Property(e => e.TvNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL5");
            entity.Property(e => e.TvNivel6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL6");
            entity.Property(e => e.TvNivel7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL7");
            entity.Property(e => e.TvNivel8)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL8");
            entity.Property(e => e.TvNivel9)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_NIVEL9");
            entity.Property(e => e.TvNomnume).HasColumnName("TV_NOMNUME");
            entity.Property(e => e.TvNomtipo).HasColumnName("TV_NOMTIPO");
            entity.Property(e => e.TvNomyear).HasColumnName("TV_NOMYEAR");
            entity.Property(e => e.TvOtras1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_OTRAS_1");
            entity.Property(e => e.TvOtras2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_OTRAS_2");
            entity.Property(e => e.TvOtras3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_OTRAS_3");
            entity.Property(e => e.TvOtras4)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_OTRAS_4");
            entity.Property(e => e.TvOtras5)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_OTRAS_5");
            entity.Property(e => e.TvPatron)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_PATRON");
            entity.Property(e => e.TvPriorid).HasColumnName("TV_PRIORID");
            entity.Property(e => e.TvPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_PUESTO");
            entity.Property(e => e.TvSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TV_SALARIO");
            entity.Property(e => e.TvTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_TABLASS");
            entity.Property(e => e.TvTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TV_TURNO");
            entity.Property(e => e.TvValor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TV_VALOR");
        });

        modelBuilder.Entity<Tmpfolio>(entity =>
        {
            entity.HasKey(e => new { e.ToUser, e.ToFolio, e.CbCodigo });

            entity.ToTable("TMPFOLIO");

            entity.Property(e => e.ToUser).HasColumnName("TO_USER");
            entity.Property(e => e.ToFolio).HasColumnName("TO_FOLIO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
        });

        modelBuilder.Entity<Tmphora>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo, e.CoNumero });

            entity.ToTable("TMPHORAS");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.MoMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MO_MONTO");
        });

        modelBuilder.Entity<Tmplabor>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo });

            entity.ToTable("TMPLABOR");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AREA");
            entity.Property(e => e.CbCheca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_CHECA");
            entity.Property(e => e.CbTurno)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TURNO");
            entity.Property(e => e.TlAplica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_APLICA");
            entity.Property(e => e.TlCalcula)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TL_CALCULA");
            entity.Property(e => e.TlStatus).HasColumnName("TL_STATUS");
        });

        modelBuilder.Entity<Tmplistum>(entity =>
        {
            entity.HasKey(e => new { e.TaUser, e.TaNivel1, e.TaNivel2, e.TaNivel3, e.TaNivel4, e.TaNivel5, e.CbCodigo, e.CoNumero, e.TaReferen });

            entity.ToTable("TMPLISTA");

            entity.Property(e => e.TaUser).HasColumnName("TA_USER");
            entity.Property(e => e.TaNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL1");
            entity.Property(e => e.TaNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL2");
            entity.Property(e => e.TaNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL3");
            entity.Property(e => e.TaNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL4");
            entity.Property(e => e.TaNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL5");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.TaReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("TA_REFEREN");
            entity.Property(e => e.PeNumero).HasColumnName("PE_NUMERO");
            entity.Property(e => e.PeTipo).HasColumnName("PE_TIPO");
            entity.Property(e => e.PeYear).HasColumnName("PE_YEAR");
            entity.Property(e => e.TaDeducci)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TA_DEDUCCI");
            entity.Property(e => e.TaHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TA_HORAS");
            entity.Property(e => e.TaPercepc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TA_PERCEPC");
            entity.Property(e => e.TaTotal).HasColumnName("TA_TOTAL");
        });

        modelBuilder.Entity<Tmpmov>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CbCodigo, e.CoNumero, e.MoReferen });

            entity.ToTable("TMPMOVS");

            entity.HasIndex(e => e.CbCodigo, "XIE1TMPMOVS");

            entity.HasIndex(e => e.CoNumero, "XIE2TMPMOVS");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.MoReferen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("MO_REFEREN");
            entity.Property(e => e.FaDiaHor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FA_DIA_HOR");
            entity.Property(e => e.FaFecIni)
                .HasColumnType("datetime")
                .HasColumnName("FA_FEC_INI");
            entity.Property(e => e.FaMotivo).HasColumnName("FA_MOTIVO");
            entity.Property(e => e.MoMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("MO_MONTO");
            entity.Property(e => e.MoTipo).HasColumnName("MO_TIPO");
        });

        modelBuilder.Entity<Tmpnom>(entity =>
        {
            entity.HasKey(e => new { e.TaUser, e.TaNivel1, e.TaNivel2, e.TaNivel3, e.TaNivel4, e.TaNivel5, e.CbCodigo });

            entity.ToTable("TMPNOM");

            entity.Property(e => e.TaUser).HasColumnName("TA_USER");
            entity.Property(e => e.TaNivel1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL1");
            entity.Property(e => e.TaNivel2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL2");
            entity.Property(e => e.TaNivel3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL3");
            entity.Property(e => e.TaNivel4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL4");
            entity.Property(e => e.TaNivel5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TA_NIVEL5");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbSalInt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SAL_INT");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.NoAdicion)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_ADICION");
            entity.Property(e => e.NoDTurno)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_D_TURNO");
            entity.Property(e => e.NoDeducci)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DEDUCCI");
            entity.Property(e => e.NoDesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DES_TRA");
            entity.Property(e => e.NoDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS");
            entity.Property(e => e.NoDiasAg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_AG");
            entity.Property(e => e.NoDiasAj)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_AJ");
            entity.Property(e => e.NoDiasAs)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_AS");
            entity.Property(e => e.NoDiasBa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_BA");
            entity.Property(e => e.NoDiasCg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_CG");
            entity.Property(e => e.NoDiasEm)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_EM");
            entity.Property(e => e.NoDiasFi)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_FI");
            entity.Property(e => e.NoDiasFj)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_FJ");
            entity.Property(e => e.NoDiasFv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_FV");
            entity.Property(e => e.NoDiasIn)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_IN");
            entity.Property(e => e.NoDiasNt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_NT");
            entity.Property(e => e.NoDiasOt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_OT");
            entity.Property(e => e.NoDiasPv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_PV");
            entity.Property(e => e.NoDiasRe)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_RE");
            entity.Property(e => e.NoDiasSg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_SG");
            entity.Property(e => e.NoDiasSi)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_SI");
            entity.Property(e => e.NoDiasSs)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_SS");
            entity.Property(e => e.NoDiasSu)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_SU");
            entity.Property(e => e.NoDiasVa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_VA");
            entity.Property(e => e.NoDiasVj)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DIAS_VJ");
            entity.Property(e => e.NoDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_DOBLES");
            entity.Property(e => e.NoExentas)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_EXENTAS");
            entity.Property(e => e.NoExtras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_EXTRAS");
            entity.Property(e => e.NoFesPag)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_FES_PAG");
            entity.Property(e => e.NoFesTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_FES_TRA");
            entity.Property(e => e.NoHorOk)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("NO_HOR_OK");
            entity.Property(e => e.NoHoraCg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORA_CG");
            entity.Property(e => e.NoHoraPd)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORA_PD");
            entity.Property(e => e.NoHoraSg)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORA_SG");
            entity.Property(e => e.NoHorapdt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORAPDT");
            entity.Property(e => e.NoHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORAS");
            entity.Property(e => e.NoHorasnt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_HORASNT");
            entity.Property(e => e.NoImpCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_IMP_CAL");
            entity.Property(e => e.NoJornada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_JORNADA");
            entity.Property(e => e.NoNeto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_NETO");
            entity.Property(e => e.NoPerCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PER_CAL");
            entity.Property(e => e.NoPerMen)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PER_MEN");
            entity.Property(e => e.NoPercepc)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PERCEPC");
            entity.Property(e => e.NoPreExt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PRE_EXT");
            entity.Property(e => e.NoPrevGr)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_PREV_GR");
            entity.Property(e => e.NoTardes)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_TARDES");
            entity.Property(e => e.NoTotPre)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_TOT_PRE");
            entity.Property(e => e.NoTriples)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_TRIPLES");
            entity.Property(e => e.NoVacTra)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_VAC_TRA");
            entity.Property(e => e.NoXCal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_X_CAL");
            entity.Property(e => e.NoXIspt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_X_ISPT");
            entity.Property(e => e.NoXMens)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("NO_X_MENS");
            entity.Property(e => e.TaTotal).HasColumnName("TA_TOTAL");
        });

        modelBuilder.Entity<Tmppromvar>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.CbFecha, e.CbTipo, e.CoNumero });

            entity.ToTable("TMPPROMVAR");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbFecha)
                .HasColumnType("datetime")
                .HasColumnName("CB_FECHA");
            entity.Property(e => e.CbTipo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TIPO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.TvDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TV_DIAS");
            entity.Property(e => e.TvMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TV_MONTO");
            entity.Property(e => e.TvProm)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TV_PROM");
            entity.Property(e => e.TvTotPro)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TV_TOT_PRO");

            entity.HasOne(d => d.Kardex).WithMany(p => p.Tmppromvars)
                .HasForeignKey(d => new { d.CbCodigo, d.CbFecha, d.CbTipo })
                .HasConstraintName("FK_PROM_VAR_KARDEX");
        });

        modelBuilder.Entity<Tmprotai>(entity =>
        {
            entity.HasKey(e => new { e.TrUser, e.CbCodigo });

            entity.ToTable("TMPROTAI");

            entity.Property(e => e.TrUser).HasColumnName("TR_USER");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbFecBaj)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_BAJ");
            entity.Property(e => e.CbFecIng)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ING");
            entity.Property(e => e.TrDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TR_DESCRIP");
            entity.Property(e => e.TrGrupo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TR_GRUPO");
        });

        modelBuilder.Entity<Tmprotum>(entity =>
        {
            entity.HasKey(e => new { e.TrUser, e.TrGrupo });

            entity.ToTable("TMPROTA");

            entity.Property(e => e.TrUser).HasColumnName("TR_USER");
            entity.Property(e => e.TrGrupo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TR_GRUPO");
            entity.Property(e => e.TrAltas).HasColumnName("TR_ALTAS");
            entity.Property(e => e.TrBajas).HasColumnName("TR_BAJAS");
            entity.Property(e => e.TrDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TR_DESCRIP");
            entity.Property(e => e.TrFecha)
                .HasColumnType("datetime")
                .HasColumnName("TR_FECHA");
            entity.Property(e => e.TrFinal).HasColumnName("TR_FINAL");
            entity.Property(e => e.TrInicio).HasColumnName("TR_INICIO");
            entity.Property(e => e.TrProm)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TR_PROM");
        });

        modelBuilder.Entity<Tmpsalar>(entity =>
        {
            entity.HasKey(e => new { e.TsUser, e.CbCodigo });

            entity.ToTable("TMPSALAR");

            entity.Property(e => e.TsUser).HasColumnName("TS_USER");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CbAutosal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AUTOSAL");
            entity.Property(e => e.CbFecAnt)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_ANT");
            entity.Property(e => e.CbFecSal)
                .HasColumnType("datetime")
                .HasColumnName("CB_FEC_SAL");
            entity.Property(e => e.CbNota)
                .HasColumnType("text")
                .HasColumnName("CB_NOTA");
            entity.Property(e => e.CbPerVar)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_PER_VAR");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CbTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TABLASS");
            entity.Property(e => e.Prettyname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRETTYNAME");
            entity.Property(e => e.TsDif)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TS_DIF");
            entity.Property(e => e.TsMonto1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TS_MONTO1");
            entity.Property(e => e.TsMonto2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TS_MONTO2");
            entity.Property(e => e.TsPor)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TS_POR");
        });

        modelBuilder.Entity<Tmptotal>(entity =>
        {
            entity.HasKey(e => new { e.UsCodigo, e.CoNumero, e.Grupo1, e.Grupo2, e.Grupo3, e.Grupo4, e.Grupo5 });

            entity.ToTable("TMPTOTAL");

            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.Grupo1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRUPO1");
            entity.Property(e => e.Grupo2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRUPO2");
            entity.Property(e => e.Grupo3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRUPO3");
            entity.Property(e => e.Grupo4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRUPO4");
            entity.Property(e => e.Grupo5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GRUPO5");
            entity.Property(e => e.TotMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TOT_MONTO");
            entity.Property(e => e.TotNumero).HasColumnName("TOT_NUMERO");
        });

        modelBuilder.Entity<Tmuerto>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TMUERTO");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Tool>(entity =>
        {
            entity.HasKey(e => e.ToCodigo);

            entity.ToTable("TOOL");

            entity.Property(e => e.ToCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TO_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.ToCosto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TO_COSTO");
            entity.Property(e => e.ToDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TO_DESCRIP");
            entity.Property(e => e.ToDescto).HasColumnName("TO_DESCTO");
            entity.Property(e => e.ToIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TO_INGLES");
            entity.Property(e => e.ToNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TO_NUMERO");
            entity.Property(e => e.ToTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TO_TEXTO");
            entity.Property(e => e.ToValBaj)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TO_VAL_BAJ");
            entity.Property(e => e.ToValRep)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TO_VAL_REP");
            entity.Property(e => e.ToVida).HasColumnName("TO_VIDA");
        });

        modelBuilder.Entity<Topera>(entity =>
        {
            entity.HasKey(e => e.ToCodigo);

            entity.ToTable("TOPERA", tb => tb.HasTrigger("TU_TOPERA"));

            entity.Property(e => e.ToCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TO_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.ToDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TO_DESCRIP");
            entity.Property(e => e.ToIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TO_INGLES");
            entity.Property(e => e.ToNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TO_NUMERO");
            entity.Property(e => e.ToTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TO_TEXTO");
        });

        modelBuilder.Entity<Tparte>(entity =>
        {
            entity.HasKey(e => e.TtCodigo);

            entity.ToTable("TPARTE", tb => tb.HasTrigger("TU_TPARTE"));

            entity.Property(e => e.TtCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TT_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TtDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TT_DESCRIP");
            entity.Property(e => e.TtIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TT_INGLES");
            entity.Property(e => e.TtNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TT_NUMERO");
            entity.Property(e => e.TtTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TT_TEXTO");
        });

        modelBuilder.Entity<Tperiodo>(entity =>
        {
            entity.HasKey(e => e.TpTipo);

            entity.ToTable("TPERIODO");

            entity.Property(e => e.TpTipo)
                .ValueGeneratedNever()
                .HasColumnName("TP_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TpDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TP_DESCRIP");
            entity.Property(e => e.TpDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_DIAS");
            entity.Property(e => e.TpDias7)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TP_DIAS_7");
            entity.Property(e => e.TpDiasBt).HasColumnName("TP_DIAS_BT");
            entity.Property(e => e.TpDiasEv)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TP_DIAS_EV");
            entity.Property(e => e.TpHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TP_HORAS");
            entity.Property(e => e.TpHorasjo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TP_HORASJO");
            entity.Property(e => e.TpNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TP_NOMBRE");
        });

        modelBuilder.Entity<Tprestum>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TPRESTA", tb => tb.HasTrigger("TU_TPRESTA"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbAlta).HasColumnName("TB_ALTA");
            entity.Property(e => e.TbConcept).HasColumnName("TB_CONCEPT");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbLiquida).HasColumnName("TB_LIQUIDA");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbPriorid).HasColumnName("TB_PRIORID");
            entity.Property(e => e.TbRelativ).HasColumnName("TB_RELATIV");
            entity.Property(e => e.TbTasa1)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA1");
            entity.Property(e => e.TbTasa2)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA2");
            entity.Property(e => e.TbTasa3)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TB_TASA3");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Transpor>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("TRANSPOR", tb => tb.HasTrigger("TU_TRANSPOR"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.TuCodigo);

            entity.ToTable("TURNO", tb => tb.HasTrigger("TU_TURNO"));

            entity.Property(e => e.TuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TuActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_ACTIVO");
            entity.Property(e => e.TuDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_DESCRIP");
            entity.Property(e => e.TuDias).HasColumnName("TU_DIAS");
            entity.Property(e => e.TuDiasBa)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TU_DIAS_BA");
            entity.Property(e => e.TuDiasOrd).HasColumnName("TU_DIAS_ORD");
            entity.Property(e => e.TuDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_DOBLES");
            entity.Property(e => e.TuDomingo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_DOMINGO");
            entity.Property(e => e.TuFestivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_FESTIVO");
            entity.Property(e => e.TuHor1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_1");
            entity.Property(e => e.TuHor2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_2");
            entity.Property(e => e.TuHor3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_3");
            entity.Property(e => e.TuHor4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_4");
            entity.Property(e => e.TuHor5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_5");
            entity.Property(e => e.TuHor6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_6");
            entity.Property(e => e.TuHor7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_7");
            entity.Property(e => e.TuHorFes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_FES");
            entity.Property(e => e.TuHorario).HasColumnName("TU_HORARIO");
            entity.Property(e => e.TuIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_INGLES");
            entity.Property(e => e.TuJornada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_JORNADA");
            entity.Property(e => e.TuNomina).HasColumnName("TU_NOMINA");
            entity.Property(e => e.TuNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_NUMERO");
            entity.Property(e => e.TuRitIni)
                .HasColumnType("datetime")
                .HasColumnName("TU_RIT_INI");
            entity.Property(e => e.TuRitPat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TU_RIT_PAT");
            entity.Property(e => e.TuSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_SUB_CTA");
            entity.Property(e => e.TuTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_TEXTO");
            entity.Property(e => e.TuTip1).HasColumnName("TU_TIP_1");
            entity.Property(e => e.TuTip2).HasColumnName("TU_TIP_2");
            entity.Property(e => e.TuTip3).HasColumnName("TU_TIP_3");
            entity.Property(e => e.TuTip4).HasColumnName("TU_TIP_4");
            entity.Property(e => e.TuTip5).HasColumnName("TU_TIP_5");
            entity.Property(e => e.TuTip6).HasColumnName("TU_TIP_6");
            entity.Property(e => e.TuTip7).HasColumnName("TU_TIP_7");
            entity.Property(e => e.TuTipJor).HasColumnName("TU_TIP_JOR");
            entity.Property(e => e.TuTipJt).HasColumnName("TU_TIP_JT");
            entity.Property(e => e.TuVacaDe)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_VACA_DE");
            entity.Property(e => e.TuVacaHa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_VACA_HA");
            entity.Property(e => e.TuVacaSa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_VACA_SA");
        });

        modelBuilder.Entity<UltimoEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ULTIMO_EMPLEADO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
        });

        modelBuilder.Entity<Uma>(entity =>
        {
            entity.HasKey(e => e.Llave).HasName("PK__UMA__E9596B3B741A0504");

            entity.ToTable("UMA");

            entity.Property(e => e.Llave).HasColumnName("LLAVE");
            entity.Property(e => e.UmaAnual).HasColumnName("UMA_ANUAL");
            entity.Property(e => e.UmaDiario).HasColumnName("UMA_DIARIO");
            entity.Property(e => e.UmaFecha).HasColumnName("UMA_FECHA");
            entity.Property(e => e.UmaMensual).HasColumnName("UMA_MENSUAL");
            entity.Property(e => e.UmaVigen).HasColumnName("UMA_VIGEN");
        });

        modelBuilder.Entity<Umi>(entity =>
        {
            entity.HasKey(e => e.Llave).HasName("PK_UMI_1");

            entity.ToTable("UMI");

            entity.Property(e => e.Llave).HasColumnName("LLAVE");
            entity.Property(e => e.UmiAnual).HasColumnName("UMI_ANUAL");
            entity.Property(e => e.UmiDiario).HasColumnName("UMI_DIARIO");
            entity.Property(e => e.UmiFecha).HasColumnName("UMI_FECHA");
            entity.Property(e => e.UmiMensual).HasColumnName("UMI_MENSUAL");
            entity.Property(e => e.UmiVigencia).HasColumnName("UMI_VIGENCIA");
        });

        modelBuilder.Entity<VAccAd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACC_AD");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AdAccion)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("AD_ACCION");
            entity.Property(e => e.AdImpacto).HasColumnName("AD_IMPACTO");
            entity.Property(e => e.AdPosicio).HasColumnName("AD_POSICIO");
            entity.Property(e => e.AdTipo).HasColumnName("AD_TIPO");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
        });

        modelBuilder.Entity<VAccDer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACC_DER");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AdAccion)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("AD_ACCION");
            entity.Property(e => e.AdImpacto).HasColumnName("AD_IMPACTO");
            entity.Property(e => e.AdPosicio).HasColumnName("AD_POSICIO");
            entity.Property(e => e.AdTipo).HasColumnName("AD_TIPO");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
        });

        modelBuilder.Entity<VAccRdd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACC_RDD");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AdAccion)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("AD_ACCION");
            entity.Property(e => e.AdImpacto).HasColumnName("AD_IMPACTO");
            entity.Property(e => e.AdPosicio).HasColumnName("AD_POSICIO");
            entity.Property(e => e.AdTipo).HasColumnName("AD_TIPO");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
        });

        modelBuilder.Entity<VAccall>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCALL");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VAccarbol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCARBOL");

            entity.Property(e => e.AaDescrip)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("AA_DESCRIP");
            entity.Property(e => e.AaModulo).HasColumnName("AA_MODULO");
            entity.Property(e => e.AaPosicio)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("AA_POSICIO");
            entity.Property(e => e.AaScreen).HasColumnName("AA_SCREEN");
            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AaVersion).HasColumnName("AA_VERSION");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmControl)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("CM_CONTROL");
        });

        modelBuilder.Entity<VAccemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCEMP");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AxDerecho).HasColumnName("AX_DERECHO");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VAcceso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCESO");

            entity.Property(e => e.AxDerecho).HasColumnName("AX_DERECHO");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VAccusu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACCUSU");

            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.UsActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_ACTIVO");
            entity.Property(e => e.UsAnfitri).HasColumnName("US_ANFITRI");
            entity.Property(e => e.UsArbol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_ARBOL");
            entity.Property(e => e.UsBioId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_BIO_ID");
            entity.Property(e => e.UsBitLst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_BIT_LST");
            entity.Property(e => e.UsBloquea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_BLOQUEA");
            entity.Property(e => e.UsCambia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_CAMBIA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.UsCorto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("US_CORTO");
            entity.Property(e => e.UsDentro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_DENTRO");
            entity.Property(e => e.UsDomain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_DOMAIN");
            entity.Property(e => e.UsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_EMAIL");
            entity.Property(e => e.UsFallas).HasColumnName("US_FALLAS");
            entity.Property(e => e.UsFecIn)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_IN");
            entity.Property(e => e.UsFecOut)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_OUT");
            entity.Property(e => e.UsFecPwd)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_PWD");
            entity.Property(e => e.UsFecSus)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_SUS");
            entity.Property(e => e.UsForma).HasColumnName("US_FORMA");
            entity.Property(e => e.UsFormato).HasColumnName("US_FORMATO");
            entity.Property(e => e.UsJefe).HasColumnName("US_JEFE");
            entity.Property(e => e.UsLugar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_LUGAR");
            entity.Property(e => e.UsMaquina)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("US_MAQUINA");
            entity.Property(e => e.UsNivel).HasColumnName("US_NIVEL");
            entity.Property(e => e.UsNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_NOMBRE");
            entity.Property(e => e.UsPaginas).HasColumnName("US_PAGINAS");
            entity.Property(e => e.UsPortal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_PORTAL");
        });

        modelBuilder.Entity<VAcumula>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ACUMULA");

            entity.Property(e => e.AcMes).HasColumnName("AC_MES");
            entity.Property(e => e.AcMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("AC_MONTO");
            entity.Property(e => e.AcYear).HasColumnName("AC_YEAR");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
        });

        modelBuilder.Entity<VAdvanceitEmpleado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ADVANCEIT_EMPLEADOS");

            entity.Property(e => e.CbApeMat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_APE_MAT");
            entity.Property(e => e.CbApePat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_APE_PAT");
            entity.Property(e => e.CbBanEle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_BAN_ELE");
            entity.Property(e => e.CbNombres)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_NOMBRES");
            entity.Property(e => e.CbRfc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_RFC");
            entity.Property(e => e.CbTel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CB_TEL");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.DiasPeriodo)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("DIAS_PERIODO");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.PuDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PU_DESCRIP");
            entity.Property(e => e.SalarioDiario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("SALARIO_DIARIO");
            entity.Property(e => e.SalarioPeriodo)
                .HasColumnType("numeric(31, 7)")
                .HasColumnName("SALARIO_PERIODO");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("TIPO_DOCUMENTO");
        });

        modelBuilder.Entity<VAdvanceitEmpresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ADVANCEIT_EMPRESA");

            entity.Property(e => e.Correo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ID_EMPRESA");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IDENTIFICACION");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Pais)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("PAIS");
            entity.Property(e => e.Periodos).HasColumnName("PERIODOS");
        });

        modelBuilder.Entity<VBitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BITACORA");

            entity.Property(e => e.BiClase).HasColumnName("BI_CLASE");
            entity.Property(e => e.BiData)
                .HasColumnType("text")
                .HasColumnName("BI_DATA");
            entity.Property(e => e.BiFecMov)
                .HasColumnType("datetime")
                .HasColumnName("BI_FEC_MOV");
            entity.Property(e => e.BiFecha)
                .HasColumnType("datetime")
                .HasColumnName("BI_FECHA");
            entity.Property(e => e.BiHora)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("BI_HORA");
            entity.Property(e => e.BiNumero).HasColumnName("BI_NUMERO");
            entity.Property(e => e.BiProcId).HasColumnName("BI_PROC_ID");
            entity.Property(e => e.BiTexto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BI_TEXTO");
            entity.Property(e => e.BiTipo).HasColumnName("BI_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<VBitcafe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BITCAFE");

            entity.Property(e => e.BcChecada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC_CHECADA");
            entity.Property(e => e.BcComidas).HasColumnName("BC_COMIDAS");
            entity.Property(e => e.BcCredenc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_CREDENC");
            entity.Property(e => e.BcEmpresa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_EMPRESA");
            entity.Property(e => e.BcExtras).HasColumnName("BC_EXTRAS");
            entity.Property(e => e.BcFecha)
                .HasColumnType("datetime")
                .HasColumnName("BC_FECHA");
            entity.Property(e => e.BcFolio)
                .ValueGeneratedOnAdd()
                .HasColumnName("BC_FOLIO");
            entity.Property(e => e.BcHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_HORA");
            entity.Property(e => e.BcManual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_MANUAL");
            entity.Property(e => e.BcMensaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC_MENSAJE");
            entity.Property(e => e.BcRegExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_REG_EXT");
            entity.Property(e => e.BcReloj)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("BC_RELOJ");
            entity.Property(e => e.BcRespues)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC_RESPUES");
            entity.Property(e => e.BcStatus).HasColumnName("BC_STATUS");
            entity.Property(e => e.BcTgafete).HasColumnName("BC_TGAFETE");
            entity.Property(e => e.BcTiempo).HasColumnName("BC_TIEMPO");
            entity.Property(e => e.BcTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ClCodigo).HasColumnName("CL_CODIGO");
            entity.Property(e => e.IvCodigo).HasColumnName("IV_CODIGO");
        });

        modelBuilder.Entity<VBitcafee>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BITCAFEE");

            entity.Property(e => e.BcChecada)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC_CHECADA");
            entity.Property(e => e.BcComidas).HasColumnName("BC_COMIDAS");
            entity.Property(e => e.BcCredenc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_CREDENC");
            entity.Property(e => e.BcEmpresa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_EMPRESA");
            entity.Property(e => e.BcExtras).HasColumnName("BC_EXTRAS");
            entity.Property(e => e.BcFecha)
                .HasColumnType("datetime")
                .HasColumnName("BC_FECHA");
            entity.Property(e => e.BcFolio)
                .ValueGeneratedOnAdd()
                .HasColumnName("BC_FOLIO");
            entity.Property(e => e.BcHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_HORA");
            entity.Property(e => e.BcManual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_MANUAL");
            entity.Property(e => e.BcMensaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC_MENSAJE");
            entity.Property(e => e.BcRegExt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_REG_EXT");
            entity.Property(e => e.BcReloj)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("BC_RELOJ");
            entity.Property(e => e.BcRespues)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BC_RESPUES");
            entity.Property(e => e.BcStatus).HasColumnName("BC_STATUS");
            entity.Property(e => e.BcTgafete).HasColumnName("BC_TGAFETE");
            entity.Property(e => e.BcTiempo).HasColumnName("BC_TIEMPO");
            entity.Property(e => e.BcTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BC_TIPO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.ClCodigo).HasColumnName("CL_CODIGO");
            entity.Property(e => e.IvCodigo).HasColumnName("IV_CODIGO");
        });

        modelBuilder.Entity<VBitkiosc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_BITKIOSC");

            entity.Property(e => e.BiAccion).HasColumnName("BI_ACCION");
            entity.Property(e => e.BiFecHor)
                .HasColumnType("datetime")
                .HasColumnName("BI_FEC_HOR");
            entity.Property(e => e.BiFecMov)
                .HasColumnType("datetime")
                .HasColumnName("BI_FEC_MOV");
            entity.Property(e => e.BiFecha)
                .HasColumnType("datetime")
                .HasColumnName("BI_FECHA");
            entity.Property(e => e.BiHora)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("BI_HORA");
            entity.Property(e => e.BiKiosco)
                .HasMaxLength(63)
                .IsUnicode(false)
                .HasColumnName("BI_KIOSCO");
            entity.Property(e => e.BiNumero).HasColumnName("BI_NUMERO");
            entity.Property(e => e.BiTexto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BI_TEXTO");
            entity.Property(e => e.BiTipo).HasColumnName("BI_TIPO");
            entity.Property(e => e.BiUbica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BI_UBICA");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
        });

        modelBuilder.Entity<VCedWord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CED_WORD");

            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CeArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_AREA");
            entity.Property(e => e.CeComenta)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CE_COMENTA");
            entity.Property(e => e.CeFecha)
                .HasColumnType("datetime")
                .HasColumnName("CE_FECHA");
            entity.Property(e => e.CeFolio).HasColumnName("CE_FOLIO");
            entity.Property(e => e.CeHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_HORA");
            entity.Property(e => e.CeMod1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MOD_1");
            entity.Property(e => e.CeMod2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MOD_2");
            entity.Property(e => e.CeMod3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MOD_3");
            entity.Property(e => e.CeMulti)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_MULTI");
            entity.Property(e => e.CePiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CE_PIEZAS");
            entity.Property(e => e.CeStatus).HasColumnName("CE_STATUS");
            entity.Property(e => e.CeTiempo)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CE_TIEMPO");
            entity.Property(e => e.CeTipo).HasColumnName("CE_TIPO");
            entity.Property(e => e.CeTmuerto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CE_TMUERTO");
            entity.Property(e => e.CwPiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("CW_PIEZAS");
            entity.Property(e => e.CwPosicio).HasColumnName("CW_POSICIO");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.Setcambios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SETCAMBIOS");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.VDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("V_DESCRIP");
            entity.Property(e => e.VarCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VAR_CODIGO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        modelBuilder.Entity<VCoXGr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CO_X_GR");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CmControl).HasColumnName("CM_CONTROL");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_COMPANY");

            entity.Property(e => e.CmAcumula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_ACUMULA");
            entity.Property(e => e.CmAlias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_ALIAS");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.CmControl)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CONTROL");
            entity.Property(e => e.CmDatos)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CM_DATOS");
            entity.Property(e => e.CmDigito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_DIGITO");
            entity.Property(e => e.CmEmpate).HasColumnName("CM_EMPATE");
            entity.Property(e => e.CmKclasifi).HasColumnName("CM_KCLASIFI");
            entity.Property(e => e.CmKconfi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_KCONFI");
            entity.Property(e => e.CmKusers)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CM_KUSERS");
            entity.Property(e => e.CmNivel0)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_NIVEL0");
            entity.Property(e => e.CmNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CM_NOMBRE");
            entity.Property(e => e.CmUsacafe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_USACAFE");
            entity.Property(e => e.CmUsrname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CM_USRNAME");
        });

        modelBuilder.Entity<VConSat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("V_CON_SAT");

            entity.Property(e => e.Concepto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Nombre)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Tipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TIPO");
        });

        modelBuilder.Entity<VConceptosAbg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CONCEPTOS_ABG");

            entity.Property(e => e.CoAPtu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_A_PTU");
            entity.Property(e => e.CoActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_ACTIVO");
            entity.Property(e => e.CoCalcula)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_CALCULA");
            entity.Property(e => e.CoCambia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_CAMBIA");
            entity.Property(e => e.CoDBlob)
                .HasColumnType("image")
                .HasColumnName("CO_D_BLOB");
            entity.Property(e => e.CoDExt)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_D_EXT");
            entity.Property(e => e.CoDNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_D_NOM");
            entity.Property(e => e.CoDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_DESCRIP");
            entity.Property(e => e.CoFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_FORMULA");
            entity.Property(e => e.CoGImss)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_G_IMSS");
            entity.Property(e => e.CoGIspt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_G_ISPT");
            entity.Property(e => e.CoGpoAcc)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("CO_GPO_ACC");
            entity.Property(e => e.CoImpCal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_IMP_CAL");
            entity.Property(e => e.CoImprime)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_IMPRIME");
            entity.Property(e => e.CoLimInf)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CO_LIM_INF");
            entity.Property(e => e.CoLimSup)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CO_LIM_SUP");
            entity.Property(e => e.CoListado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_LISTADO");
            entity.Property(e => e.CoMensual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_MENSUAL");
            entity.Property(e => e.CoNota)
                .HasColumnType("text")
                .HasColumnName("CO_NOTA");
            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.CoOrden).HasColumnName("CO_ORDEN");
            entity.Property(e => e.CoQuery)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_QUERY");
            entity.Property(e => e.CoRecibo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_RECIBO");
            entity.Property(e => e.CoSql)
                .IsUnicode(false)
                .HasColumnName("CO_SQL");
            entity.Property(e => e.CoSqlImpc)
                .IsUnicode(false)
                .HasColumnName("CO_SQL_IMPC");
            entity.Property(e => e.CoSqlIspt)
                .IsUnicode(false)
                .HasColumnName("CO_SQL_ISPT");
            entity.Property(e => e.CoSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CO_SUB_CTA");
            entity.Property(e => e.CoTipo).HasColumnName("CO_TIPO");
            entity.Property(e => e.CoVerAcc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_VER_ACC");
            entity.Property(e => e.CoVerInf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_VER_INF");
            entity.Property(e => e.CoVerSup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CO_VER_SUP");
            entity.Property(e => e.CoXIspt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CO_X_ISPT");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
        });

        modelBuilder.Entity<VConceptosSat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CONCEPTOS_SAT");

            entity.Property(e => e.CoNumero).HasColumnName("CO_NUMERO");
            entity.Property(e => e.CoSat)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CO_SAT");
            entity.Property(e => e.CoTipo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CO_TIPO");
        });

        modelBuilder.Entity<VContraCuenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CONTRA_CUENTAS");

            entity.Property(e => e.Concepto).HasColumnName("CONCEPTO");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
        });

        modelBuilder.Entity<VCurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CURSO");

            entity.Property(e => e.CuActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_ACTIVO");
            entity.Property(e => e.CuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CU_CODIGO");
            entity.Property(e => e.CuCosto1)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_COSTO1");
            entity.Property(e => e.CuCosto2)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_COSTO2");
            entity.Property(e => e.CuCosto3)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_COSTO3");
            entity.Property(e => e.CuFolio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CU_FOLIO");
            entity.Property(e => e.CuHoras)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CU_HORAS");
            entity.Property(e => e.CuNombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CU_NOMBRE");
            entity.Property(e => e.CuRevisio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CU_REVISIO");
            entity.Property(e => e.MaCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MA_CODIGO");
        });

        modelBuilder.Entity<VDisposit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DISPOSIT");

            entity.Property(e => e.DiDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DI_DESCRIP");
            entity.Property(e => e.DiIp)
                .HasMaxLength(63)
                .IsUnicode(false)
                .HasColumnName("DI_IP");
            entity.Property(e => e.DiNombre)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DI_NOMBRE");
            entity.Property(e => e.DiNota)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DI_NOTA");
            entity.Property(e => e.DiTipo).HasColumnName("DI_TIPO");
        });

        modelBuilder.Entity<VDisxcom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_DISXCOM");

            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.DiNombre)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("DI_NOMBRE");
            entity.Property(e => e.DiTipo).HasColumnName("DI_TIPO");
        });

        modelBuilder.Entity<VEntfedAbg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ENTFED_ABG");

            entity.Property(e => e.EnCodigo)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("EN_CODIGO");
            entity.Property(e => e.EnDescrip)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("EN_DESCRIP");
            entity.Property(e => e.EnEstado)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("EN_ESTADO");
        });

        modelBuilder.Entity<VGlobalAbg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_GLOBAL_ABG");

            entity.Property(e => e.GlCaptura)
                .HasColumnType("datetime")
                .HasColumnName("GL_CAPTURA");
            entity.Property(e => e.GlCodigo).HasColumnName("GL_CODIGO");
            entity.Property(e => e.GlDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GL_DESCRIP");
            entity.Property(e => e.GlFormula)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GL_FORMULA");
            entity.Property(e => e.GlNivel).HasColumnName("GL_NIVEL");
            entity.Property(e => e.GlSql)
                .IsUnicode(false)
                .HasColumnName("GL_SQL");
            entity.Property(e => e.GlTipo).HasColumnName("GL_TIPO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<VGradall>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_GRADALL");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AxNumero)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_GRUPO");

            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.GrDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GR_DESCRIP");
            entity.Property(e => e.GrPadre).HasColumnName("GR_PADRE");
        });

        modelBuilder.Entity<VLiqEmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_LIQ_EMP");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.LeAcumula)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_ACUMULA");
            entity.Property(e => e.LeBimAnt)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("LE_BIM_ANT");
            entity.Property(e => e.LeBimSig)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("LE_BIM_SIG");
            entity.Property(e => e.LeDiasBm).HasColumnName("LE_DIAS_BM");
            entity.Property(e => e.LeInfAmo)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("LE_INF_AMO");
            entity.Property(e => e.LeInfPat)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("LE_INF_PAT");
            entity.Property(e => e.LeProv)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("LE_PROV");
            entity.Property(e => e.LeTotInf)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("LE_TOT_INF");
            entity.Property(e => e.LeVaGozo).HasColumnName("LE_VA_GOZO");
            entity.Property(e => e.LeVaPago).HasColumnName("LE_VA_PAGO");
            entity.Property(e => e.LsMonth).HasColumnName("LS_MONTH");
            entity.Property(e => e.LsYear).HasColumnName("LS_YEAR");
        });

        modelBuilder.Entity<VMotBajaIdse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MOT_BAJA_IDSE");

            entity.Property(e => e.CodigoIdse)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CODIGO_IDSE");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("DESCRIPCION");
        });

        modelBuilder.Entity<VNavDato>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_NAV_DATOS");

            entity.Property(e => e.NavAnio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_ANIO");
            entity.Property(e => e.NavDesctnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_DESCTNOM");
            entity.Property(e => e.NavIdsesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_IDSESION");
            entity.Property(e => e.NavNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_NOMBRE");
            entity.Property(e => e.NavNomina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_NOMINA");
            entity.Property(e => e.NavNumnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_NUMNOM");
            entity.Property(e => e.NavTnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_TNOM");
            entity.Property(e => e.NavUsersesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAV_USERSESION");
        });

        modelBuilder.Entity<VNavimssDato>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_NAVIMSS_DATOS");

            entity.Property(e => e.NavimssAnio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_ANIO");
            entity.Property(e => e.NavimssIdsesion).HasColumnName("NAVIMSS_IDSESION");
            entity.Property(e => e.NavimssMes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_MES");
            entity.Property(e => e.NavimssRegpat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_REGPAT");
            entity.Property(e => e.NavimssTipo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_TIPO");
            entity.Property(e => e.NavimssUsersesion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_USERSESION");
        });

        modelBuilder.Entity<VNavimssDatosbn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_NAVIMSS_DATOSBN");

            entity.Property(e => e.NavimssAnio)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_ANIO");
            entity.Property(e => e.NavimssIdpat)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_IDPAT");
            entity.Property(e => e.NavimssIdsesion).HasColumnName("NAVIMSS_IDSESION");
            entity.Property(e => e.NavimssMes)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_MES");
            entity.Property(e => e.NavimssRegpat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_REGPAT");
            entity.Property(e => e.NavimssTipo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_TIPO");
            entity.Property(e => e.NavimssUsersesion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAVIMSS_USERSESION");
        });

        modelBuilder.Entity<VNivel0>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_NIVEL0");

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
        });

        modelBuilder.Entity<VPoll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_POLL");

            entity.Property(e => e.PoEmpresa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PO_EMPRESA");
            entity.Property(e => e.PoFecha)
                .HasColumnType("datetime")
                .HasColumnName("PO_FECHA");
            entity.Property(e => e.PoHora)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PO_HORA");
            entity.Property(e => e.PoLetra)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PO_LETRA");
            entity.Property(e => e.PoLinx)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("PO_LINX");
            entity.Property(e => e.PoNumero).HasColumnName("PO_NUMERO");
        });

        modelBuilder.Entity<VPrinter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PRINTER");

            entity.Property(e => e.Pi6Lines)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_6_LINES");
            entity.Property(e => e.Pi8Lines)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_8_LINES");
            entity.Property(e => e.PiBoldOf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_BOLD_OF");
            entity.Property(e => e.PiBoldOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_BOLD_ON");
            entity.Property(e => e.PiChar10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_CHAR_10");
            entity.Property(e => e.PiChar12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_CHAR_12");
            entity.Property(e => e.PiChar17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_CHAR_17");
            entity.Property(e => e.PiEject)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_EJECT");
            entity.Property(e => e.PiExtra1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_EXTRA_1");
            entity.Property(e => e.PiExtra2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_EXTRA_2");
            entity.Property(e => e.PiItalOf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_ITAL_OF");
            entity.Property(e => e.PiItalOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_ITAL_ON");
            entity.Property(e => e.PiLandsca)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_LANDSCA");
            entity.Property(e => e.PiNombre)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasColumnName("PI_NOMBRE");
            entity.Property(e => e.PiReset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_RESET");
            entity.Property(e => e.PiUndeOf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_UNDE_OF");
            entity.Property(e => e.PiUndeOn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PI_UNDE_ON");
        });

        modelBuilder.Entity<VRclaall>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RCLAALL");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VRentall>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_RENTALL");

            entity.Property(e => e.AaSource).HasColumnName("AA_SOURCE");
            entity.Property(e => e.AxNumero).HasColumnName("AX_NUMERO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
        });

        modelBuilder.Entity<VReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_REPORTE");

            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.QuCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("QU_CODIGO");
            entity.Property(e => e.ReAlto)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_ALTO");
            entity.Property(e => e.ReAncho)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_ANCHO");
            entity.Property(e => e.ReArchivo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RE_ARCHIVO");
            entity.Property(e => e.ReCandado).HasColumnName("RE_CANDADO");
            entity.Property(e => e.ReCfecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RE_CFECHA");
            entity.Property(e => e.ReClasifi).HasColumnName("RE_CLASIFI");
            entity.Property(e => e.ReCodigo).HasColumnName("RE_CODIGO");
            entity.Property(e => e.ReColespa)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_COLESPA");
            entity.Property(e => e.ReColnum).HasColumnName("RE_COLNUM");
            entity.Property(e => e.ReCopias).HasColumnName("RE_COPIAS");
            entity.Property(e => e.ReEntidad).HasColumnName("RE_ENTIDAD");
            entity.Property(e => e.ReFecha)
                .HasColumnType("datetime")
                .HasColumnName("RE_FECHA");
            entity.Property(e => e.ReFiltro)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RE_FILTRO");
            entity.Property(e => e.ReFontnam)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("RE_FONTNAM");
            entity.Property(e => e.ReFontsiz).HasColumnName("RE_FONTSIZ");
            entity.Property(e => e.ReGeneral)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RE_GENERAL");
            entity.Property(e => e.ReHoja).HasColumnName("RE_HOJA");
            entity.Property(e => e.ReIfecha).HasColumnName("RE_IFECHA");
            entity.Property(e => e.ReMarDer)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_DER");
            entity.Property(e => e.ReMarInf)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_INF");
            entity.Property(e => e.ReMarIzq)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_IZQ");
            entity.Property(e => e.ReMarSup)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_MAR_SUP");
            entity.Property(e => e.ReNivel).HasColumnName("RE_NIVEL");
            entity.Property(e => e.ReNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RE_NOMBRE");
            entity.Property(e => e.RePfile).HasColumnName("RE_PFILE");
            entity.Property(e => e.RePrinter)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("RE_PRINTER");
            entity.Property(e => e.ReRenespa)
                .HasColumnType("numeric(15, 3)")
                .HasColumnName("RE_RENESPA");
            entity.Property(e => e.ReReporte)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("RE_REPORTE");
            entity.Property(e => e.ReSolot)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RE_SOLOT");
            entity.Property(e => e.ReTipo).HasColumnName("RE_TIPO");
            entity.Property(e => e.ReTitulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RE_TITULO");
            entity.Property(e => e.ReVertica)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RE_VERTICA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
        });

        modelBuilder.Entity<VTurnoAbg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_TURNO_ABG");

            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TuActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_ACTIVO");
            entity.Property(e => e.TuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_CODIGO");
            entity.Property(e => e.TuDescrip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_DESCRIP");
            entity.Property(e => e.TuDias).HasColumnName("TU_DIAS");
            entity.Property(e => e.TuDiasBa)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("TU_DIAS_BA");
            entity.Property(e => e.TuDiasOrd).HasColumnName("TU_DIAS_ORD");
            entity.Property(e => e.TuDobles)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_DOBLES");
            entity.Property(e => e.TuDomingo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_DOMINGO");
            entity.Property(e => e.TuFestivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_FESTIVO");
            entity.Property(e => e.TuHor1)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_1");
            entity.Property(e => e.TuHor2)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_2");
            entity.Property(e => e.TuHor3)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_3");
            entity.Property(e => e.TuHor4)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_4");
            entity.Property(e => e.TuHor5)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_5");
            entity.Property(e => e.TuHor6)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_6");
            entity.Property(e => e.TuHor7)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_7");
            entity.Property(e => e.TuHorFes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TU_HOR_FES");
            entity.Property(e => e.TuHorario).HasColumnName("TU_HORARIO");
            entity.Property(e => e.TuIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_INGLES");
            entity.Property(e => e.TuJornada)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_JORNADA");
            entity.Property(e => e.TuNomina).HasColumnName("TU_NOMINA");
            entity.Property(e => e.TuNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_NUMERO");
            entity.Property(e => e.TuRitIni)
                .HasColumnType("datetime")
                .HasColumnName("TU_RIT_INI");
            entity.Property(e => e.TuRitPat)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TU_RIT_PAT");
            entity.Property(e => e.TuSubCta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_SUB_CTA");
            entity.Property(e => e.TuTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TU_TEXTO");
            entity.Property(e => e.TuTip1).HasColumnName("TU_TIP_1");
            entity.Property(e => e.TuTip2).HasColumnName("TU_TIP_2");
            entity.Property(e => e.TuTip3).HasColumnName("TU_TIP_3");
            entity.Property(e => e.TuTip4).HasColumnName("TU_TIP_4");
            entity.Property(e => e.TuTip5).HasColumnName("TU_TIP_5");
            entity.Property(e => e.TuTip6).HasColumnName("TU_TIP_6");
            entity.Property(e => e.TuTip7).HasColumnName("TU_TIP_7");
            entity.Property(e => e.TuTipJor).HasColumnName("TU_TIP_JOR");
            entity.Property(e => e.TuTipJt).HasColumnName("TU_TIP_JT");
            entity.Property(e => e.TuVacaDe)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_VACA_DE");
            entity.Property(e => e.TuVacaHa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_VACA_HA");
            entity.Property(e => e.TuVacaSa)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TU_VACA_SA");
        });

        modelBuilder.Entity<VUmaAbg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_UMA_ABG");

            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UmaAnual).HasColumnName("UMA_ANUAL");
            entity.Property(e => e.UmaDiario).HasColumnName("UMA_DIARIO");
            entity.Property(e => e.UmaFecha).HasColumnName("UMA_FECHA");
            entity.Property(e => e.UmaMensual).HasColumnName("UMA_MENSUAL");
            entity.Property(e => e.UmaVigen).HasColumnName("UMA_VIGEN");
        });

        modelBuilder.Entity<VUmiAbg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_UMI_ABG");

            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UmiAnual).HasColumnName("UMI_ANUAL");
            entity.Property(e => e.UmiDiario).HasColumnName("UMI_DIARIO");
            entity.Property(e => e.UmiFecha).HasColumnName("UMI_FECHA");
            entity.Property(e => e.UmiMensual).HasColumnName("UMI_MENSUAL");
            entity.Property(e => e.UmiVigencia).HasColumnName("UMI_VIGENCIA");
        });

        modelBuilder.Entity<VUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_USUARIO");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.UsActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_ACTIVO");
            entity.Property(e => e.UsAnfitri).HasColumnName("US_ANFITRI");
            entity.Property(e => e.UsArbol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_ARBOL");
            entity.Property(e => e.UsBioId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_BIO_ID");
            entity.Property(e => e.UsBitLst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_BIT_LST");
            entity.Property(e => e.UsBloquea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_BLOQUEA");
            entity.Property(e => e.UsCambia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_CAMBIA");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.UsCorto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("US_CORTO");
            entity.Property(e => e.UsDentro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_DENTRO");
            entity.Property(e => e.UsDomain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_DOMAIN");
            entity.Property(e => e.UsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_EMAIL");
            entity.Property(e => e.UsFallas).HasColumnName("US_FALLAS");
            entity.Property(e => e.UsFecIn)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_IN");
            entity.Property(e => e.UsFecOut)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_OUT");
            entity.Property(e => e.UsFecPwd)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_PWD");
            entity.Property(e => e.UsFecSus)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_SUS");
            entity.Property(e => e.UsForma).HasColumnName("US_FORMA");
            entity.Property(e => e.UsFormato).HasColumnName("US_FORMATO");
            entity.Property(e => e.UsJefe).HasColumnName("US_JEFE");
            entity.Property(e => e.UsLugar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_LUGAR");
            entity.Property(e => e.UsMaquina)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("US_MAQUINA");
            entity.Property(e => e.UsNivel).HasColumnName("US_NIVEL");
            entity.Property(e => e.UsNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_NOMBRE");
            entity.Property(e => e.UsPaginas).HasColumnName("US_PAGINAS");
            entity.Property(e => e.UsPortal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_PORTAL");
        });

        modelBuilder.Entity<VValPto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VAL_PTO");

            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VpComenta)
                .HasColumnType("text")
                .HasColumnName("VP_COMENTA");
            entity.Property(e => e.VpFecFin)
                .HasColumnType("datetime")
                .HasColumnName("VP_FEC_FIN");
            entity.Property(e => e.VpFecIni)
                .HasColumnType("datetime")
                .HasColumnName("VP_FEC_INI");
            entity.Property(e => e.VpFecha)
                .HasColumnType("datetime")
                .HasColumnName("VP_FECHA");
            entity.Property(e => e.VpFolio).HasColumnName("VP_FOLIO");
            entity.Property(e => e.VpGrado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_GRADO");
            entity.Property(e => e.VpNumFin).HasColumnName("VP_NUM_FIN");
            entity.Property(e => e.VpPtCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VP_PT_CODE");
            entity.Property(e => e.VpPtGrad)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_PT_GRAD");
            entity.Property(e => e.VpPtNom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VP_PT_NOM");
            entity.Property(e => e.VpPuntos)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("VP_PUNTOS");
            entity.Property(e => e.VpStatus).HasColumnName("VP_STATUS");
            entity.Property(e => e.VpUltima)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("VP_ULTIMA");
        });

        modelBuilder.Entity<VValplant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VALPLANT");

            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VlComenta)
                .HasColumnType("text")
                .HasColumnName("VL_COMENTA");
            entity.Property(e => e.VlFecha)
                .HasColumnType("datetime")
                .HasColumnName("VL_FECHA");
            entity.Property(e => e.VlIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VL_INGLES");
            entity.Property(e => e.VlMaxPts)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("VL_MAX_PTS");
            entity.Property(e => e.VlMinPts)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("VL_MIN_PTS");
            entity.Property(e => e.VlNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VL_NOMBRE");
            entity.Property(e => e.VlNumFac).HasColumnName("VL_NUM_FAC");
            entity.Property(e => e.VlNumPto).HasColumnName("VL_NUM_PTO");
            entity.Property(e => e.VlNumSub).HasColumnName("VL_NUM_SUB");
            entity.Property(e => e.VlNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VL_NUMERO");
            entity.Property(e => e.VlStatus).HasColumnName("VL_STATUS");
            entity.Property(e => e.VlTabPts).HasColumnName("VL_TAB_PTS");
            entity.Property(e => e.VlTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VL_TEXTO");
        });

        modelBuilder.Entity<VVfactor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VFACTOR");

            entity.Property(e => e.VfCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VF_CODIGO");
            entity.Property(e => e.VfDesIng)
                .HasColumnType("text")
                .HasColumnName("VF_DES_ING");
            entity.Property(e => e.VfDescrip)
                .HasColumnType("text")
                .HasColumnName("VF_DESCRIP");
            entity.Property(e => e.VfIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VF_INGLES");
            entity.Property(e => e.VfMaxPts)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("VF_MAX_PTS");
            entity.Property(e => e.VfMinPts)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("VF_MIN_PTS");
            entity.Property(e => e.VfNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VF_NOMBRE");
            entity.Property(e => e.VfNumSub).HasColumnName("VF_NUM_SUB");
            entity.Property(e => e.VfNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VF_NUMERO");
            entity.Property(e => e.VfOrden).HasColumnName("VF_ORDEN");
            entity.Property(e => e.VfTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VF_TEXTO");
            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
        });

        modelBuilder.Entity<VVpunto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VPUNTOS");

            entity.Property(e => e.Llave).HasColumnName("LLAVE");
            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VnCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VN_CODIGO");
            entity.Property(e => e.VnColor).HasColumnName("VN_COLOR");
            entity.Property(e => e.VnDesIng)
                .HasColumnType("text")
                .HasColumnName("VN_DES_ING");
            entity.Property(e => e.VnDescrip)
                .HasColumnType("text")
                .HasColumnName("VN_DESCRIP");
            entity.Property(e => e.VnIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VN_INGLES");
            entity.Property(e => e.VnNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VN_NOMBRE");
            entity.Property(e => e.VnNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VN_NUMERO");
            entity.Property(e => e.VnOrden).HasColumnName("VN_ORDEN");
            entity.Property(e => e.VnPuntos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VN_PUNTOS");
            entity.Property(e => e.VnTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VN_TEXTO");
            entity.Property(e => e.VpFolio).HasColumnName("VP_FOLIO");
            entity.Property(e => e.VsOrden).HasColumnName("VS_ORDEN");
            entity.Property(e => e.VtComenta)
                .HasColumnType("text")
                .HasColumnName("VT_COMENTA");
            entity.Property(e => e.VtCual).HasColumnName("VT_CUAL");
            entity.Property(e => e.VtOrden).HasColumnName("VT_ORDEN");
            entity.Property(e => e.VtPuntos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VT_PUNTOS");
        });

        modelBuilder.Entity<VVsubfact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_VSUBFACT");

            entity.Property(e => e.VfOrden).HasColumnName("VF_ORDEN");
            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VsCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VS_CODIGO");
            entity.Property(e => e.VsDesIng)
                .HasColumnType("text")
                .HasColumnName("VS_DES_ING");
            entity.Property(e => e.VsDescrip)
                .HasColumnType("text")
                .HasColumnName("VS_DESCRIP");
            entity.Property(e => e.VsIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VS_INGLES");
            entity.Property(e => e.VsMaxPts)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VS_MAX_PTS");
            entity.Property(e => e.VsMinPts)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VS_MIN_PTS");
            entity.Property(e => e.VsNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VS_NOMBRE");
            entity.Property(e => e.VsNumNiv).HasColumnName("VS_NUM_NIV");
            entity.Property(e => e.VsNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VS_NUMERO");
            entity.Property(e => e.VsOrden).HasColumnName("VS_ORDEN");
            entity.Property(e => e.VsTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VS_TEXTO");
        });

        modelBuilder.Entity<Vacacion>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.VaFecIni, e.VaTipo });

            entity.ToTable("VACACION");

            entity.HasIndex(e => new { e.VaTipo, e.VaNomyear, e.VaNomtipo, e.CbCodigo, e.VaNomnume }, "XIE1VACACION");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.VaFecIni)
                .HasColumnType("datetime")
                .HasColumnName("VA_FEC_INI");
            entity.Property(e => e.VaTipo).HasColumnName("VA_TIPO");
            entity.Property(e => e.CbSalario)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("CB_SALARIO");
            entity.Property(e => e.CbTablass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_TABLASS");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.VaAjuste)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VA_AJUSTE");
            entity.Property(e => e.VaCaptura)
                .HasColumnType("datetime")
                .HasColumnName("VA_CAPTURA");
            entity.Property(e => e.VaComenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VA_COMENTA");
            entity.Property(e => e.VaDGozo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_D_GOZO");
            entity.Property(e => e.VaDPago)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_D_PAGO");
            entity.Property(e => e.VaDPrima)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_D_PRIMA");
            entity.Property(e => e.VaFecFin)
                .HasColumnType("datetime")
                .HasColumnName("VA_FEC_FIN");
            entity.Property(e => e.VaGlobal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VA_GLOBAL");
            entity.Property(e => e.VaGozo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_GOZO");
            entity.Property(e => e.VaMonto)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_MONTO");
            entity.Property(e => e.VaNomnume).HasColumnName("VA_NOMNUME");
            entity.Property(e => e.VaNomtipo).HasColumnName("VA_NOMTIPO");
            entity.Property(e => e.VaNomyear).HasColumnName("VA_NOMYEAR");
            entity.Property(e => e.VaOtros)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_OTROS");
            entity.Property(e => e.VaPPrima)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_P_PRIMA");
            entity.Property(e => e.VaPago)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_PAGO");
            entity.Property(e => e.VaPeriodo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VA_PERIODO");
            entity.Property(e => e.VaPrima)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_PRIMA");
            entity.Property(e => e.VaSGozo)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_S_GOZO");
            entity.Property(e => e.VaSPago)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_S_PAGO");
            entity.Property(e => e.VaSPrima)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_S_PRIMA");
            entity.Property(e => e.VaSeven)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_SEVEN");
            entity.Property(e => e.VaTasaPr)
                .HasColumnType("numeric(15, 5)")
                .HasColumnName("VA_TASA_PR");
            entity.Property(e => e.VaTotal)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VA_TOTAL");
            entity.Property(e => e.VaYear).HasColumnName("VA_YEAR");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Vacacions)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_Vacacion_Colabora");
        });

        modelBuilder.Entity<Vacaplan>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.VpFecIni });

            entity.ToTable("VACAPLAN");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.VpFecIni)
                .HasColumnType("datetime")
                .HasColumnName("VP_FEC_INI");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.VpAutCom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VP_AUT_COM");
            entity.Property(e => e.VpAutFec)
                .HasColumnType("datetime")
                .HasColumnName("VP_AUT_FEC");
            entity.Property(e => e.VpAutUsr).HasColumnName("VP_AUT_USR");
            entity.Property(e => e.VpDias)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_DIAS");
            entity.Property(e => e.VpFecFin)
                .HasColumnType("datetime")
                .HasColumnName("VP_FEC_FIN");
            entity.Property(e => e.VpNomnume).HasColumnName("VP_NOMNUME");
            entity.Property(e => e.VpNomtipo).HasColumnName("VP_NOMTIPO");
            entity.Property(e => e.VpNomyear).HasColumnName("VP_NOMYEAR");
            entity.Property(e => e.VpPagoUs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VP_PAGO_US");
            entity.Property(e => e.VpSalAnt)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_SAL_ANT");
            entity.Property(e => e.VpSalPro)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_SAL_PRO");
            entity.Property(e => e.VpSolCom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VP_SOL_COM");
            entity.Property(e => e.VpSolFec)
                .HasColumnType("datetime")
                .HasColumnName("VP_SOL_FEC");
            entity.Property(e => e.VpSolUsr).HasColumnName("VP_SOL_USR");
            entity.Property(e => e.VpStatus).HasColumnName("VP_STATUS");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Vacaplans)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_VACAPLAN_COLABORA");
        });

        modelBuilder.Entity<ValPto>(entity =>
        {
            entity.HasKey(e => e.VpFolio);

            entity.ToTable("VAL_PTO");

            entity.HasIndex(e => new { e.PuCodigo, e.VpFecha }, "XAK1VAL_PTO").IsUnique();

            entity.Property(e => e.VpFolio).HasColumnName("VP_FOLIO");
            entity.Property(e => e.PuCodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PU_CODIGO");
            entity.Property(e => e.UsCodigo).HasColumnName("US_CODIGO");
            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VpComenta)
                .HasColumnType("text")
                .HasColumnName("VP_COMENTA");
            entity.Property(e => e.VpFecFin)
                .HasColumnType("datetime")
                .HasColumnName("VP_FEC_FIN");
            entity.Property(e => e.VpFecIni)
                .HasColumnType("datetime")
                .HasColumnName("VP_FEC_INI");
            entity.Property(e => e.VpFecha)
                .HasColumnType("datetime")
                .HasColumnName("VP_FECHA");
            entity.Property(e => e.VpGrado)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_GRADO");
            entity.Property(e => e.VpPtCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VP_PT_CODE");
            entity.Property(e => e.VpPtGrad)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VP_PT_GRAD");
            entity.Property(e => e.VpPtNom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VP_PT_NOM");
            entity.Property(e => e.VpStatus).HasColumnName("VP_STATUS");

            entity.HasOne(d => d.PuCodigoNavigation).WithMany(p => p.ValPtos)
                .HasForeignKey(d => d.PuCodigo)
                .HasConstraintName("FK_Val_Pto_Puesto");

            entity.HasOne(d => d.VlCodigoNavigation).WithMany(p => p.ValPtos)
                .HasForeignKey(d => d.VlCodigo)
                .HasConstraintName("FK_Val_Pto_ValPLant");
        });

        modelBuilder.Entity<Valnivel>(entity =>
        {
            entity.HasKey(e => new { e.VlCodigo, e.VsOrden, e.VnOrden });

            entity.ToTable("VALNIVEL");

            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VsOrden).HasColumnName("VS_ORDEN");
            entity.Property(e => e.VnOrden).HasColumnName("VN_ORDEN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.VnCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VN_CODIGO");
            entity.Property(e => e.VnColor).HasColumnName("VN_COLOR");
            entity.Property(e => e.VnDesIng)
                .HasColumnType("text")
                .HasColumnName("VN_DES_ING");
            entity.Property(e => e.VnDescrip)
                .HasColumnType("text")
                .HasColumnName("VN_DESCRIP");
            entity.Property(e => e.VnIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VN_INGLES");
            entity.Property(e => e.VnNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VN_NOMBRE");
            entity.Property(e => e.VnNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VN_NUMERO");
            entity.Property(e => e.VnPuntos)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VN_PUNTOS");
            entity.Property(e => e.VnTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VN_TEXTO");

            entity.HasOne(d => d.Vsubfact).WithMany(p => p.Valnivels)
                .HasForeignKey(d => new { d.VlCodigo, d.VsOrden })
                .HasConstraintName("FK_ValNivel_VSubFact");
        });

        modelBuilder.Entity<Valplant>(entity =>
        {
            entity.HasKey(e => e.VlCodigo);

            entity.ToTable("VALPLANT");

            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VlComenta)
                .HasColumnType("text")
                .HasColumnName("VL_COMENTA");
            entity.Property(e => e.VlFecha)
                .HasColumnType("datetime")
                .HasColumnName("VL_FECHA");
            entity.Property(e => e.VlIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VL_INGLES");
            entity.Property(e => e.VlNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VL_NOMBRE");
            entity.Property(e => e.VlNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VL_NUMERO");
            entity.Property(e => e.VlStatus).HasColumnName("VL_STATUS");
            entity.Property(e => e.VlTabPts).HasColumnName("VL_TAB_PTS");
            entity.Property(e => e.VlTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VL_TEXTO");
        });

        modelBuilder.Entity<Vfactor>(entity =>
        {
            entity.HasKey(e => new { e.VlCodigo, e.VfOrden });

            entity.ToTable("VFACTOR", tb =>
                {
                    tb.HasTrigger("TD_VFACTOR");
                    tb.HasTrigger("TU_VFACTOR");
                });

            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VfOrden).HasColumnName("VF_ORDEN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.VfCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VF_CODIGO");
            entity.Property(e => e.VfDesIng)
                .HasColumnType("text")
                .HasColumnName("VF_DES_ING");
            entity.Property(e => e.VfDescrip)
                .HasColumnType("text")
                .HasColumnName("VF_DESCRIP");
            entity.Property(e => e.VfIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VF_INGLES");
            entity.Property(e => e.VfNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VF_NOMBRE");
            entity.Property(e => e.VfNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VF_NUMERO");
            entity.Property(e => e.VfTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VF_TEXTO");

            entity.HasOne(d => d.VlCodigoNavigation).WithMany(p => p.Vfactors)
                .HasForeignKey(d => d.VlCodigo)
                .HasConstraintName("FK_VFactor_ValPlant");
        });

        modelBuilder.Entity<ViveCon>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("VIVE_CON", tb => tb.HasTrigger("TU_VIVE_CON"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<ViveEn>(entity =>
        {
            entity.HasKey(e => e.TbCodigo);

            entity.ToTable("VIVE_EN", tb => tb.HasTrigger("TU_VIVE_EN"));

            entity.Property(e => e.TbCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TB_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.TbElement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_ELEMENT");
            entity.Property(e => e.TbIngles)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_INGLES");
            entity.Property(e => e.TbNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("TB_NUMERO");
            entity.Property(e => e.TbTexto)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TB_TEXTO");
        });

        modelBuilder.Entity<Vpunto>(entity =>
        {
            entity.HasKey(e => new { e.VpFolio, e.VtOrden });

            entity.ToTable("VPUNTOS");

            entity.Property(e => e.VpFolio).HasColumnName("VP_FOLIO");
            entity.Property(e => e.VtOrden).HasColumnName("VT_ORDEN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.VtComenta)
                .HasColumnType("text")
                .HasColumnName("VT_COMENTA");
            entity.Property(e => e.VtCual).HasColumnName("VT_CUAL");

            entity.HasOne(d => d.VpFolioNavigation).WithMany(p => p.Vpuntos)
                .HasForeignKey(d => d.VpFolio)
                .HasConstraintName("FK_VPuntos_Val_Pto");
        });

        modelBuilder.Entity<Vsubfact>(entity =>
        {
            entity.HasKey(e => new { e.VlCodigo, e.VsOrden });

            entity.ToTable("VSUBFACT");

            entity.Property(e => e.VlCodigo).HasColumnName("VL_CODIGO");
            entity.Property(e => e.VsOrden).HasColumnName("VS_ORDEN");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.VfOrden).HasColumnName("VF_ORDEN");
            entity.Property(e => e.VsCodigo)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("VS_CODIGO");
            entity.Property(e => e.VsDesIng)
                .HasColumnType("text")
                .HasColumnName("VS_DES_ING");
            entity.Property(e => e.VsDescrip)
                .HasColumnType("text")
                .HasColumnName("VS_DESCRIP");
            entity.Property(e => e.VsIngles)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VS_INGLES");
            entity.Property(e => e.VsNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VS_NOMBRE");
            entity.Property(e => e.VsNumero)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("VS_NUMERO");
            entity.Property(e => e.VsTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VS_TEXTO");

            entity.HasOne(d => d.VlCodigoNavigation).WithMany(p => p.Vsubfacts)
                .HasForeignKey(d => d.VlCodigo)
                .HasConstraintName("FK_VSubFact_ValPlant");
        });

        modelBuilder.Entity<Wofija>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.WfFecIni });

            entity.ToTable("WOFIJA");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.WfFecIni)
                .HasColumnType("datetime")
                .HasColumnName("WF_FEC_INI");
            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");

            entity.HasOne(d => d.CbCodigoNavigation).WithMany(p => p.Wofijas)
                .HasForeignKey(d => d.CbCodigo)
                .HasConstraintName("FK_WOFija_Colabora");

            entity.HasOne(d => d.WoNumberNavigation).WithMany(p => p.Wofijas)
                .HasForeignKey(d => d.WoNumber)
                .HasConstraintName("FK_WOFija_Worder");
        });

        modelBuilder.Entity<Worder>(entity =>
        {
            entity.HasKey(e => e.WoNumber);

            entity.ToTable("WORDER", tb => tb.HasTrigger("TU_WORDER"));

            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.WoDescrip)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("WO_DESCRIP");
            entity.Property(e => e.WoFecCie)
                .HasColumnType("datetime")
                .HasColumnName("WO_FEC_CIE");
            entity.Property(e => e.WoFecFin)
                .HasColumnType("datetime")
                .HasColumnName("WO_FEC_FIN");
            entity.Property(e => e.WoFecIni)
                .HasColumnType("datetime")
                .HasColumnName("WO_FEC_INI");
            entity.Property(e => e.WoFinishd)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("WO_FINISHD");
            entity.Property(e => e.WoLstStp).HasColumnName("WO_LST_STP");
            entity.Property(e => e.WoNumGen)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("WO_NUM_GEN");
            entity.Property(e => e.WoQty)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("WO_QTY");
            entity.Property(e => e.WoStatus).HasColumnName("WO_STATUS");
            entity.Property(e => e.WoTexto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("WO_TEXTO");
        });

        modelBuilder.Entity<Work>(entity =>
        {
            entity.HasKey(e => new { e.CbCodigo, e.AuFecha, e.WkHoraA, e.WkFolio });

            entity.ToTable("WORKS");

            entity.HasIndex(e => new { e.WoNumber, e.OpNumber }, "XIE1WORKS");

            entity.HasIndex(e => new { e.WoNumber, e.CbCodigo }, "XIE2WORKS");

            entity.HasIndex(e => new { e.AuFecha, e.WkHoraA }, "XIE3WORKS");

            entity.HasIndex(e => e.WkCedula, "XIE4WORKS");

            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.AuFecha)
                .HasColumnType("datetime")
                .HasColumnName("AU_FECHA");
            entity.Property(e => e.WkHoraA)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_HORA_A");
            entity.Property(e => e.WkFolio).HasColumnName("WK_FOLIO");
            entity.Property(e => e.ArCodigo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AR_CODIGO");
            entity.Property(e => e.CbArea)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_AREA");
            entity.Property(e => e.CbPuesto)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CB_PUESTO");
            entity.Property(e => e.Llave)
                .ValueGeneratedOnAdd()
                .HasColumnName("LLAVE");
            entity.Property(e => e.OpNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OP_NUMBER");
            entity.Property(e => e.WkCedula).HasColumnName("WK_CEDULA");
            entity.Property(e => e.WkFechaR)
                .HasColumnType("datetime")
                .HasColumnName("WK_FECHA_R");
            entity.Property(e => e.WkHoraI)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_HORA_I");
            entity.Property(e => e.WkHoraR)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_HORA_R");
            entity.Property(e => e.WkHrs2ex)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("WK_HRS_2EX");
            entity.Property(e => e.WkHrs3ex)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("WK_HRS_3EX");
            entity.Property(e => e.WkHrsOrd)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("WK_HRS_ORD");
            entity.Property(e => e.WkLinxId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("WK_LINX_ID");
            entity.Property(e => e.WkManual)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_MANUAL");
            entity.Property(e => e.WkMod1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_MOD_1");
            entity.Property(e => e.WkMod2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_MOD_2");
            entity.Property(e => e.WkMod3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_MOD_3");
            entity.Property(e => e.WkPiezas)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("WK_PIEZAS");
            entity.Property(e => e.WkPreCal)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("WK_PRE_CAL");
            entity.Property(e => e.WkStatus).HasColumnName("WK_STATUS");
            entity.Property(e => e.WkStdCst)
                .HasColumnType("numeric(15, 2)")
                .HasColumnName("WK_STD_CST");
            entity.Property(e => e.WkStdHr)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("WK_STD_HR");
            entity.Property(e => e.WkTiempo)
                .HasColumnType("numeric(15, 4)")
                .HasColumnName("WK_TIEMPO");
            entity.Property(e => e.WkTipo).HasColumnName("WK_TIPO");
            entity.Property(e => e.WkTmuerto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("WK_TMUERTO");
            entity.Property(e => e.WoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WO_NUMBER");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
