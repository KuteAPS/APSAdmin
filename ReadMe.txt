******************************************************************************************
******************************************************************************************
*******************************Management�ֲ�*********************************************
******************************************************************************************
******************************************************************************************

									Ӧ�ü���

MVC5��� + Subsonic2.2 + SqlServer2008 + MSMQ��Ϣ���� + BootStrap + ��̳�JS��� + ���ݶԳƼ���



									�ֲ�ṹ
UI:ManagementAdmin
�߼��㣺ManagementBLL
���Ĳ㣺ManagementCore
���ݲ㣺ManagementDAL
ʵ��㣺ManagementModels
��Ϣ���У�ManagementMsmq
���ݰ�ȫ��MangementSecurity


�߼���ManagementBLL  --  ��ݹ���������DataHelperBll��

1.��ѯ���ݵĸ��ַ���
	1-1.��ѯĳ�ű���������� (�����ڱ�,��ͼ)---- GetDataByTable<T>(string tableName)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		���ش��뷺�͵�List����
		����new DataHelperBll().GetDataByTable<TBasisWebGroup>(TBasisWebGroup.Schema.TableName)

	1-2.��ѯĳ�ű���������� (�����ڱ�,��ͼ)---- GetDataByTableJson<T>(string tableName)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		���� JSON ���л��� WebReturnJsonModel������ ����SuccessΪ�˴�ִ�е�״̬  JsonMsg ΪJSON���л��Ĵ��뷺�͵�List����
		����new DataHelperBll().GetDataByTable<TBasisWebGroup>(TBasisWebGroup.Schema.TableName)
	
	1-3.��ҳ��ȡ���� (�����ڱ�,��ͼ)---  GetDataByPage<T>(int currentPage, int pageSize, string tableName)
		����ΪҪ���ص�List����
		����currentPage Ϊƫ���� ���磺ÿҳ������10����һҳΪ0���ڶ�ҳΪ10
		����pageSize Ϊÿҳ���� 
		����tableName ΪҪ��ѯ�ı��� 
		���ش��뷺�͵�List����
		����new DataHelperBll().GetDataByPage<VUser>(1, 10, VUser.Schema.TableName) ��ȫ������BootStrap-Table��ҳ

	1-4.����ĳһ�У���������ѯ (�����ڱ�,��ͼ)  --- GetDataByCoumObj<T>(string tableName, string cloums, List<string> values, string typed)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		����cloums Ϊ�������� 
		����values Ϊ�������� 
		����typed Ϊ��������,����Ϊ and / or 
		���ش��뷺�͵�List����

	1-5. ����ĳһ�У�����������ѯ (�����ڱ�,��ͼ)  --- GetDataByCoumObject<T>(string tableName, string cloums, object values)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		����cloums Ϊ�������� 
		����values Ϊ����ֵ
		���ش��뷺�͵�List����

	1-6. ����ĳһ�У�����������ѯ (�����ڱ�,��ͼ)  --- GetDataByCoumJson<T>(string tableName, string cloums, object values)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		����cloums Ϊ�������� 
		����values Ϊ����ֵ
		���� JSON ���л��� WebReturnJsonModel������ ����SuccessΪ�˴�ִ�е�״̬  JsonMsg ΪJSON���л��Ĵ��뷺�͵�List����

	1-7. ���ݶ��У���������ѯ (�����ڱ�,��ͼ)  --- GetDataByCoumsObj<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums, Dictionary<string, object> values, string type)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		����cloums Ϊ������ֵ�Լ��� Key��Ӧvalues��key
		����values Ϊ����ֵ�ļ�ֵ�Լ��� Key��Ӧcloums��key
		����type Ϊ��������,����Ϊ and / or 
		���� ���뷺�͵�List����


	1-8. ���ݶ��У���������ѯ (�����ڱ�,��ͼ)  --- GetDataByCoumsJson<T>(string tableName, Dictionary<string, TableSchema.TableColumn> cloums, Dictionary<string, object> values, string type)
		����ΪҪ���ص�List����
		����tableName ΪҪ��ѯ�ı��� 
		����cloums Ϊ������ֵ�Լ��� Key��Ӧvalues��key
		����values Ϊ����ֵ�ļ�ֵ�Լ��� Key��Ӧcloums��key
		����type Ϊ��������,����Ϊ and / or 
		���� JSON ���л��� WebReturnJsonModel������ ����SuccessΪ�˴�ִ�е�״̬  JsonMsg ΪJSON���л��Ĵ��뷺�͵�List����




2.ɾ�����ݵĸ��ַ���
	
	2-1. ���ݵ��У���������ɾ��������� (�����ڱ�)  --- DelData<T>(TableSchema.TableColumn column, List<string> list) 
		����ΪҪɾ���ı���
		����column ΪҪɾ������ 
		����list Ϊ��������,���ÿ���������е�����ɾ��
		���� JSON ���л��� WebReturnJsonModel������ ����SuccessΪ�˴�ִ�е�״̬��success ִ�гɹ���warning ���ֳɹ���error ʧ�ܣ�  JsonMsg ��������ʾ�ı�
	
	2-2. ���ݵ��У���������ɾ��һ������ (�����ڱ�)  --- DelData<T>(TableSchema.TableColumn column, object obj) 
		����ΪҪɾ���ı���
		����column ΪҪɾ������ 
		����list Ϊ��������,���ÿ���������е�����ɾ��
		���� JSON ���л��� WebReturnJsonModel������ ����SuccessΪ�˴�ִ�е�״̬��success ִ�гɹ���error ʧ�ܣ�  JsonMsg ��������ʾ�ı�


3.����ʶ�������޸ĸ�������			

	3-1. ���ݵ��У���������ɾ��һ������ (�����ڱ�)  --- AddOrUpdateDataById(Type tableClassTyped, string id, Dictionary<string, object> dictionary)
		����ΪҪɾ���ı���
		����tableClassTyped ΪҪִ��Model�����ȫ�޶���  
		����id ΪҪִ��Model������� 
		����dictionary Ϊ�������Զ�Ӧֵ,Key�������������һ��  
		���� JSON ���л��� WebReturnJsonModel������ ����SuccessΪ�˴�ִ�е�״̬��success ִ�гɹ���error ִ��ʧ�ܣ�  JsonMsg ��������ʾ�ı�






JS������

���ڱ��ĵ��� -------����ѹ��JS��   @Scripts.Render("~/system/bootstraptableExport")

//��TableAdmin��񵼳���png��ʽ
 <button type="button" class="btn btn-outline btn-default" onclick="doExport('#TableAdmin', { type: 'png' });">
	<i aria-hidden="true">PNG</i>
</button>

//��TableAdmin��񵼳���excel��ʽ
<button type="button" class="btn btn-outline btn-default" onclick="doExport('#TableAdmin', { type: 'excel' });">
	<i aria-hidden="true">excel</i>
</button>

//��TableAdmin��񵼳���pdf��ʽ
<button type="button" class="btn btn-outline btn-default" onclick="doExport('#TableAdmin', { type: 'pdf', jspdf: { orientation: 'p', unit: 'mm', autotable: false } });">
	<i aria-hidden="true">PDF</i>
</button>


 ����س������ļ��̼���
	
	keydowntrigger(JS����)
	��ҳ��IDΪ btn_submit �� ȫ��Ĭ�ϸ���


���ύ����Ϣ��ʾ

	FormSubmit(�ύ��ַ, ���л���)
	�ύ�󷵻�״̬��Toast��ʾ


��ѡ����ύ
	PostData(tables, url, o, refreshTable)
	����ѡ���ύ����̨��һ�����ڱ���ɾ���Ȳ������ύ�󷵻�״̬��Toast��ʾ


JS��Toast��ʾ��������
	AjaxDataToastShow(JSON���л���WebReturnJsonModel����)

�赯���༭������
	EditData(tables, url)
	����Ҫ�༭�������ڵı��ͱ༭�������õ�URL���ڣ����ݱ���ѡ��һ����Ĭ�ϴ��ݵĲ���Ϊѡ�����ݵ�ID���Զ�URL��̬���������URL����Ҫ������Ҫ֧�ֲ������ұ���֧�ֲ���ID


Toast������ʾJS����
	ToastShow(title, msg, timeOut, clickMsg, type) 
	�����������Ϊ�����⣬��ʾ��Ϣ����ʾʱ�䣬���ʱ��ʾ��Ϣ������
